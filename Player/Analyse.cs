using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic;
using pcapdatacopy;

namespace Player
{
    public enum TYPE_OF_SOURCE
    {
        CURRENT = 0,
        NEW = 1
    }
    public enum FROM
    {
        FILE = 0,
        FOLDER = 1,
        FILE_FOLDER = 2
    }
    
    public class Analyse
    {
        const bool DISABLE = false;
        const bool ENABLE = true;
        const bool DISABLE_NOTI = DISABLE;
        const bool ENABLE_NOTI = ENABLE;
        private FROM source_status;
        private Form1 processor;
        private EventArgs err;
        private List<string> audioList;

        public Analyse(ref Form1 processor, ref EventArgs err, ref List<string> audioList)
        {
            this.processor = processor;
            this.err = err;
            this.audioList = audioList;
        }

        public void OpenFile(ref Form1 processor, ref EventArgs err, ref List<string> audioList)
        {
            processor.selectfile_Click(processor.selectfile_button, err);
            
        }

        public void SetFolder(ref Form1 processor,ref EventArgs err, ref List<string> audioList)
        {
            processor.selectfolder_button_Click(processor.selectfile_button, err);
            //if (processor.folder_selected_textbox.Text.Length > 0)
            //{
            //    processor.create_raw_file_Click(processor.detect_rtp, err);
            //    this.GenerateAudio(ref processor, ref err, ENABLE_NOTI, ref audioList);
            //}
        }
        public List<string> UseFile(ref Form1 processor, string currentFile, ref EventArgs err, ref List<string> audioList, MODE _MODE)
        {
            processor.use_current_file(currentFile, err);
            processor.create_raw_file_Click(processor.detect_rtp, err);
            //Interaction.MsgBox("scanned files list", MsgBoxStyle.OkOnly, "scan clicked -> analyse.usefile");
            if(_MODE == MODE.QUIET)
                return new List<string>(this.GenerateAudio(ref processor, ref err, false, ref audioList));
            else
                return new List<string>(this.GenerateAudio(ref processor, ref err, true, ref audioList));
        }
        public List<string> UseFile(ref Form1 processor, string currentFile, ref EventArgs err, ref List<string> audioList)
        {
            processor.use_current_file(currentFile, err);
            processor.create_raw_file_Click(processor.detect_rtp, err);
            //Interaction.MsgBox("scanned files list", MsgBoxStyle.OkOnly, "scan clicked -> analyse.usefile");
            List<string> l= this.GenerateAudio(ref processor, ref err, ENABLE_NOTI, ref audioList);
            return new List<string>(this.GenerateAudio(ref processor, ref err, ENABLE_NOTI, ref audioList));
        }
        /*
        public List<string> ScanFile(ref Form1 processor, ref EventArgs err, string fileToScan, ref List<string> audioList)//scan on demand
        {
            //processor.selectfile_Click(processor.selectfile_button, err);
            processor.use_file(fileToScan, err);
            processor.create_raw_file_Click(processor.detect_rtp, err);
            Interaction.MsgBox("scanned files list", MsgBoxStyle.OkOnly, "scan clicked -> analyse.scanfile");
            return this.GenerateAudio(ref processor, ref err,ENABLE_NOTI, ref audioList);
            //return this.processor.rtp_list.Count;
        }
        */
        public List<string> ScanFolder(ref Form1 processor, ref EventArgs err, string folderToScan, ref List<string> audioList)
        {
            //processor.selectfolder_button_Click(processor.selectfile_button, err);
            processor.use_folder(folderToScan, err);
            processor.create_raw_file_Click(processor.detect_rtp, err);
            Interaction.MsgBox("scanned folders list", MsgBoxStyle.OkOnly, "scan clicked -> analyse.scanfolder");
            return new List<string>(this.GenerateAudio(ref processor, ref err,ENABLE_NOTI, ref audioList));
            //return this.processor.rtp_list.Count;
        }

        public List<string> GenerateAudio(ref Form1 processor, ref EventArgs err, bool noti, ref List<string> audioList) {
            List<string> audio_list = new List<string>();
            if (processor.file_selected_textbox.Text.Length > 0 || processor.folder_selected_textbox.Text.Length > 0)
            {
                int stream_detected = processor.rtp_list.Count;
                if (stream_detected > 0)
                {
                    //add audio path to list

                    processor.create_raw_file_Click(processor.create_audio_rtp_files_button, err);
                    audio_list = processor.popAllRtp_list_processed();
                    //Interaction.MsgBox("audio list ben trong generate audio = "+ audio_list.Count, MsgBoxStyle.OkOnly, "neu co gia tri thi return false");
                    foreach (string filename in audio_list)
                    {
                        try
                        {
                            File.Delete(filename + ".bin");
                        }
                        catch (IOException e)
                        {
                            Interaction.MsgBox(e.Message, MsgBoxStyle.OkOnly, "Delete false");
                        }

                        if (!this.audioList.Contains(filename))
                        {
                            
                            this.audioList.Add(filename);
                        }

                    }

                    this.audioList = this.audioList.Distinct().ToList();
                    string audio = "";
                    foreach (string audiofile in this.audioList) audio += audiofile + "\n";
                    ///string str = fileInfo.Name.Replace(".bin", ".wav");
                    audio += this.audioList.Count.ToString();
                    //Interaction.MsgBox(audio, MsgBoxStyle.OkOnly, "Audio list from generate audio");
                    //Interaction.MsgBox("audio list co " + this.audioList.Count + ":\n"+audio, MsgBoxStyle.OkOnly, "debug");
                    if(noti) Interaction.MsgBox(stream_detected + " stream detected\n" +
                        "Audio created at " + processor.raw_rtp_output_folder.Text, MsgBoxStyle.OkOnly, "Scan " + processor.file_selected_textbox.Text);
                }
                else if(noti) Interaction.MsgBox("No RTP audio stream found", MsgBoxStyle.OkOnly, "Scan "+ processor.file_selected_textbox.Text);
            }
            
            else if(noti) Interaction.MsgBox("Choose a pcap file or a folder contains pcap files to use this function.", MsgBoxStyle.OkOnly, "No file selected");
            return new List<string>(audio_list);
        }
        /*
        public Analyse(TYPE_OF_SOURCE type_of_source, string source)
        {
            Form1 session = new Form1();
            EventArgs err = new EventArgs();
            if (type_of_source == TYPE_OF_SOURCE.CURRENT)
            {
                session.use_current_file(source, err);
            }
            else if (type_of_source == TYPE_OF_SOURCE.NEW)
            {
               
            }

            if (session.file_selected_textbox.Text.Length > 0)
            {
                session.create_raw_file_Click(session.detect_rtp, err);
                int stream_detected = session.rtp_list.Count;
                if (stream_detected > 0)
                {
                    session.create_raw_file_Click(session.create_audio_rtp_files_button, err);
                    Interaction.MsgBox(stream_detected + " stream detected\n" +
                        "Audio created at " + session.raw_rtp_output_folder.Text, MsgBoxStyle.OkOnly, "VoIP Service");
                }
                else Interaction.MsgBox("No RTP audio stream found", MsgBoxStyle.OkOnly, "VoIP Service");
            }
            else
            {
                MsgBoxResult action = Interaction.MsgBox("Please choose a pcap file", MsgBoxStyle.OkCancel, "VoIP Service");
                if (action == MsgBoxResult.Ok)
                {
                    Analyse_voip(TYPE_OF_SOURCE.NEW, "");
                }

            }
        }
        */
    }
}
