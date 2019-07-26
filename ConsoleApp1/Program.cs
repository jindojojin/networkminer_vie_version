using System;
using System.Globalization;
using System.Collections;

namespace ConsoleApp1
{
     class Rtp
     {
        public float start_time;
        public float end_time;
        public string src_ip;
        public int src_port;
        public string dst_ip;
        public int dst_port;
        public string ssrc;
        public string payload_type;
     }
    class Program
    {   
        static string[] splitString(string s){
            string[] arr = new string[20];
            int i = 0;
            int count = 0;
            while (s[i] == ' ') i++;
            int first = i;
            int prev = i;
            for (int j=first;j<s.Length;j++)
            {
                if (s[j] == ' ' && s[j - 1] == ' ') continue;
                else if (s[j]!=' ' && s[j-1]==' ')
                {
                    prev = j;
                }
                else if (s[j]==' ')
                {
                    arr[count] =s.Substring(prev,j-prev);
                    count++;
                }
            }
            if (s[s.Length-1]!=' ')
            {
                arr[count]= s.Substring(prev, s.Length - prev);
            }
            return arr;
        }
        static void runHandle(string s)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string cmd= "/C .\\Handletool\\" + s;
            startInfo.Arguments = cmd;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
        static void Main(string[] args)
        {
            string pcap_name = "input.pcap";
            string pcap_edit = "edit_" + pcap_name;
            runHandle("editcap -d "+pcap_name+" "+pcap_edit);
            string dir = "rtp.txt";

            runHandle("tshark -r "+pcap_edit+ " -q -z rtp,streams > "+dir);
            int count = 0;
            ArrayList rtpList= new ArrayList();
            using (var reader = new System.IO.StreamReader(dir))
            {
                 reader.ReadLine(); // skip first
                 reader.ReadLine();
                 string line;
                 while ((line = reader.ReadLine()) != null)
                 {
                    if (line[0] == '=') break;
                    count++;
                    string[] paras = splitString(line);
                    Rtp rtp = new Rtp();
                    rtp.start_time = float.Parse(paras[0], CultureInfo.InvariantCulture.NumberFormat);
                    rtp.end_time= float.Parse(paras[1], CultureInfo.InvariantCulture.NumberFormat);
                    rtp.src_ip = paras[2];
                    rtp.src_port = int.Parse(paras[3], CultureInfo.InvariantCulture.NumberFormat);
                    rtp.dst_ip = paras[4];
                    rtp.dst_port= int.Parse(paras[5], CultureInfo.InvariantCulture.NumberFormat);
                    rtp.ssrc = paras[6];
                    rtp.payload_type = paras[7];
                    if (rtp.payload_type[rtp.payload_type.Length-1]==',')
                    {
                        rtp.payload_type = rtp.payload_type.Substring(0, rtp.payload_type.Length - 1);
                    }
                    rtpList.Add(rtp);
                }
            }
            foreach (Rtp rtp in rtpList) {
                string name = rtp.payload_type + rtp.src_ip + rtp.dst_ip;
                string cmd = "tshark -r " + pcap_edit + " -Y \"rtp.ssrc==" + rtp.ssrc + "\"" + " -T fields -e rtp.payload > " + name + ".raw";
                runHandle(cmd);
                runHandle("str2bin " + name + ".raw");
                if (rtp.payload_type=="g729" || rtp.payload_type == "G729")
                {
                    string decode_cmd = "cp_g729_decoder.exe haha.raw " + name + ".pcm";
                    Console.WriteLine(decode_cmd);
                    runHandle(decode_cmd);

                }
            } 
            Console.ReadKey();
        }
    }
}
