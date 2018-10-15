using System;
using System.Collections.Generic;
using System.Linq;
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
        private FROM source_status;
        private Form1 processor;
        private EventArgs err;

        public Analyse(ref Form1 processor, ref EventArgs err)
        {
            this.processor = processor;
            this.err = err;
        }

        public void OpenFile(ref Form1 processor, ref EventArgs err){
            processor.selectfile_Click(processor.selectfile_button, err);
            processor.create_raw_file_Click(processor.detect_rtp, err);
            this.GenerateAudio(ref processor,ref err);
        }
        public void OpenFolder(ref Form1 processor,ref EventArgs err){
            processor.selectfolder_button_Click(processor.selectfile_button, err);
            processor.create_raw_file_Click(processor.detect_rtp, err);
            this.GenerateAudio(ref processor,ref err);
        }
        public void UseFile(ref Form1 processor, string currentFile, ref EventArgs err)
        {
            processor.use_current_file(currentFile, err);
            processor.create_raw_file_Click(processor.detect_rtp, err);
            this.GenerateAudio(ref processor, ref err);
        }
        
        
        public void Scan(Form1 processor, EventArgs err)
        {
            if(processor.file_selected_textbox.Text.Length > 0 || processor.folder_selected_textbox.Text.Length > 0)
            {

            }
        }
        
        public void GenerateAudio(ref Form1 processor, ref EventArgs err) {
            if (processor.file_selected_textbox.Text.Length > 0 || processor.folder_selected_textbox.Text.Length > 0)
            {
                int stream_detected = processor.rtp_list.Count;
                if (stream_detected > 0)
                {
                    processor.create_raw_file_Click(processor.create_audio_rtp_files_button, err);
                    Interaction.MsgBox(stream_detected + " stream detected\n" +
                        "Audio created at " + processor.raw_rtp_output_folder.Text, MsgBoxStyle.OkOnly, "VoIP Service");
                }
                else Interaction.MsgBox("No RTP audio stream found", MsgBoxStyle.OkOnly, "VoIP Service");
            }
            
            else Interaction.MsgBox("Choose a pcap file or a folder contains pcap files to use this function.", MsgBoxStyle.OkOnly, "No file selected");
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
