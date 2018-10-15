using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using pcapdatacopy.My;

namespace pcapdatacopy
{
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0000282C File Offset: 0x00000C2C
		public Form1()
		{
			base.Load += this.Form1_Load;
			List<WeakReference> _ENCList = Form1.__ENCList;
			lock (_ENCList)
			{
				Form1.__ENCList.Add(new WeakReference(this));
			}
			this.arraycount = 0;
			this.matchcount = 1;
			this.cancelprocessing = false;
			this.analyse = false;
			this.pcap = false;
			this.rtp_analysis = false;
			this.rtp_write_raw = false;
			this.rtp_write_audio = false;
			this.rtp_counter = new int[10001];
			this.rtp_list = new List<string>();
			this.rtp_source_port = new List<string>();
			this.rtp_destination_port = new List<string>();
			this.rtp_stream_count = 0;
			this.match_rtp_packet = false;
			this.protocol_type = 0;
			this.protocol_name = "";
			this.old_file = "";
			this.file_loaded = false;
			this.init_wireshark_header = 24;
			this.normal_wireshark_header = 16;
			this.InitializeComponent();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00004820 File Offset: 0x00002C20
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00004838 File Offset: 0x00002C38
		internal virtual OpenFileDialog OpenFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OpenFileDialog1 = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00004844 File Offset: 0x00002C44
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000485C File Offset: 0x00002C5C
		public virtual Button selectfile_button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._selectfile_button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.selectfile_Click);
				bool flag = this._selectfile_button != null;
				if (flag)
				{
					this._selectfile_button.Click -= value2;
				}
				this._selectfile_button = value;
				flag = (this._selectfile_button != null);
				if (flag)
				{
					this._selectfile_button.Click += value2;
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000048BC File Offset: 0x00002CBC
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000048D4 File Offset: 0x00002CD4
		public virtual TextBox file_selected_textbox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._file_selected_textbox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._file_selected_textbox = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000048E0 File Offset: 0x00002CE0
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000048F8 File Offset: 0x00002CF8
		internal virtual TextBox raw_output_file_textbox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._raw_output_file_textbox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.raw_output_file_textbox_TextChanged);
				bool flag = this._raw_output_file_textbox != null;
				if (flag)
				{
					this._raw_output_file_textbox.TextChanged -= value2;
				}
				this._raw_output_file_textbox = value;
				flag = (this._raw_output_file_textbox != null);
				if (flag)
				{
					this._raw_output_file_textbox.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00004958 File Offset: 0x00002D58
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00004970 File Offset: 0x00002D70
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000497C File Offset: 0x00002D7C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00004994 File Offset: 0x00002D94
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000049A0 File Offset: 0x00002DA0
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000049B8 File Offset: 0x00002DB8
		internal virtual Button create_raw_file_button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._create_raw_file_button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.create_raw_file_Click);
				bool flag = this._create_raw_file_button != null;
				if (flag)
				{
					this._create_raw_file_button.Click -= value2;
				}
				this._create_raw_file_button = value;
				flag = (this._create_raw_file_button != null);
				if (flag)
				{
					this._create_raw_file_button.Click += value2;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004A18 File Offset: 0x00002E18
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00004A30 File Offset: 0x00002E30
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004A3C File Offset: 0x00002E3C
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00004A54 File Offset: 0x00002E54
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004A60 File Offset: 0x00002E60
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00004A78 File Offset: 0x00002E78
		internal virtual Label current_status_label
		{
			[DebuggerNonUserCode]
			get
			{
				return this._current_status_label;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._current_status_label = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004A84 File Offset: 0x00002E84
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004A9C File Offset: 0x00002E9C
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004AA8 File Offset: 0x00002EA8
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00004AC0 File Offset: 0x00002EC0
		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004ACC File Offset: 0x00002ECC
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00004AE4 File Offset: 0x00002EE4
		internal virtual Button dummy_button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dummy_button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dummy_button = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00004AF0 File Offset: 0x00002EF0
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00004B08 File Offset: 0x00002F08
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FolderBrowserDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FolderBrowserDialog1 = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00004B14 File Offset: 0x00002F14
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00004B2C File Offset: 0x00002F2C
		internal virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00004B38 File Offset: 0x00002F38
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00004B50 File Offset: 0x00002F50
		internal virtual Button selectfolder_button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._selectfolder_button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.selectfolder_button_Click);
				bool flag = this._selectfolder_button != null;
				if (flag)
				{
					this._selectfolder_button.Click -= value2;
				}
				this._selectfolder_button = value;
				flag = (this._selectfolder_button != null);
				if (flag)
				{
					this._selectfolder_button.Click += value2;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00004BB0 File Offset: 0x00002FB0
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00004BC8 File Offset: 0x00002FC8
		public virtual TextBox folder_selected_textbox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._folder_selected_textbox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._folder_selected_textbox = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004BD4 File Offset: 0x00002FD4
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00004BEC File Offset: 0x00002FEC
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00004BF8 File Offset: 0x00002FF8
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00004C10 File Offset: 0x00003010
		internal virtual GroupBox GroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00004C1C File Offset: 0x0000301C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00004C34 File Offset: 0x00003034
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00004C40 File Offset: 0x00003040
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00004C58 File Offset: 0x00003058
		internal virtual NumericUpDown payload_offset
		{
			[DebuggerNonUserCode]
			get
			{
				return this._payload_offset;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._payload_offset = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00004C64 File Offset: 0x00003064
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00004C7C File Offset: 0x0000307C
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00004C88 File Offset: 0x00003088
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00004CA0 File Offset: 0x000030A0
		internal virtual NumericUpDown header_length
		{
			[DebuggerNonUserCode]
			get
			{
				return this._header_length;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._header_length = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00004CAC File Offset: 0x000030AC
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00004CC4 File Offset: 0x000030C4
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00004CD0 File Offset: 0x000030D0
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00004CE8 File Offset: 0x000030E8
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00004CF4 File Offset: 0x000030F4
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00004D0C File Offset: 0x0000310C
		internal virtual Button analyse_file
		{
			[DebuggerNonUserCode]
			get
			{
				return this._analyse_file;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.create_raw_file_Click);
				bool flag = this._analyse_file != null;
				if (flag)
				{
					this._analyse_file.Click -= value2;
				}
				this._analyse_file = value;
				flag = (this._analyse_file != null);
				if (flag)
				{
					this._analyse_file.Click += value2;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00004D6C File Offset: 0x0000316C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00004D84 File Offset: 0x00003184
		internal virtual ComboBox destination_ip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._destination_ip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._destination_ip1 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00004D90 File Offset: 0x00003190
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00004DA8 File Offset: 0x000031A8
		internal virtual ComboBox source_ip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._source_ip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._source_ip1 = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004DB4 File Offset: 0x000031B4
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00004DCC File Offset: 0x000031CC
		internal virtual GroupBox GroupBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox7 = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004DD8 File Offset: 0x000031D8
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00004DF0 File Offset: 0x000031F0
		internal virtual ComboBox destination_ip2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._destination_ip2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._destination_ip2 = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004DFC File Offset: 0x000031FC
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00004E14 File Offset: 0x00003214
		internal virtual ComboBox source_ip2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._source_ip2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._source_ip2 = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004E20 File Offset: 0x00003220
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00004E38 File Offset: 0x00003238
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00004E44 File Offset: 0x00003244
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00004E5C File Offset: 0x0000325C
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004E68 File Offset: 0x00003268
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00004E80 File Offset: 0x00003280
		internal virtual CheckBox filter2_checkbox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._filter2_checkbox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._filter2_checkbox = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00004E8C File Offset: 0x0000328C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00004EA4 File Offset: 0x000032A4
		internal virtual ComboBox packet_type
		{
			[DebuggerNonUserCode]
			get
			{
				return this._packet_type;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._packet_type = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004EB0 File Offset: 0x000032B0
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00004EC8 File Offset: 0x000032C8
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004ED4 File Offset: 0x000032D4
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00004EEC File Offset: 0x000032EC
		internal virtual GroupBox GroupBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox6 = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004EF8 File Offset: 0x000032F8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00004F10 File Offset: 0x00003310
		internal virtual TextBox merged_output_file_textbox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._merged_output_file_textbox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.merged_output_file_textbox_TextChanged);
				bool flag = this._merged_output_file_textbox != null;
				if (flag)
				{
					this._merged_output_file_textbox.TextChanged -= value2;
				}
				this._merged_output_file_textbox = value;
				flag = (this._merged_output_file_textbox != null);
				if (flag)
				{
					this._merged_output_file_textbox.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004F70 File Offset: 0x00003370
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00004F88 File Offset: 0x00003388
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00004F94 File Offset: 0x00003394
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00004FAC File Offset: 0x000033AC
		internal virtual Button create_merged_file_button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._create_merged_file_button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.create_raw_file_Click);
				bool flag = this._create_merged_file_button != null;
				if (flag)
				{
					this._create_merged_file_button.Click -= value2;
				}
				this._create_merged_file_button = value;
				flag = (this._create_merged_file_button != null);
				if (flag)
				{
					this._create_merged_file_button.Click += value2;
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000500C File Offset: 0x0000340C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00005024 File Offset: 0x00003424
		internal virtual GroupBox GroupBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox8 = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005030 File Offset: 0x00003430
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00005048 File Offset: 0x00003448
		public virtual TextBox raw_rtp_output_folder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._raw_rtp_output_folder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._raw_rtp_output_folder = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005054 File Offset: 0x00003454
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000506C File Offset: 0x0000346C
		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00005078 File Offset: 0x00003478
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00005090 File Offset: 0x00003490
		internal virtual Button create_raw_rtp_file_button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._create_raw_rtp_file_button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.create_raw_file_Click);
				bool flag = this._create_raw_rtp_file_button != null;
				if (flag)
				{
					this._create_raw_rtp_file_button.Click -= value2;
				}
				this._create_raw_rtp_file_button = value;
				flag = (this._create_raw_rtp_file_button != null);
				if (flag)
				{
					this._create_raw_rtp_file_button.Click += value2;
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000050F0 File Offset: 0x000034F0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00005108 File Offset: 0x00003508
		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005114 File Offset: 0x00003514
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000512C File Offset: 0x0000352C
		public virtual Button detect_rtp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._detect_rtp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.create_raw_file_Click);
				bool flag = this._detect_rtp != null;
				if (flag)
				{
					this._detect_rtp.Click -= value2;
				}
				this._detect_rtp = value;
				flag = (this._detect_rtp != null);
				if (flag)
				{
					this._detect_rtp.Click += value2;
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000518C File Offset: 0x0000358C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000051A4 File Offset: 0x000035A4
		public virtual TextBox rtp_status
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rtp_status;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rtp_status = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000051B0 File Offset: 0x000035B0
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000051C8 File Offset: 0x000035C8
		public virtual Button create_audio_rtp_files_button
		{
			[DebuggerNonUserCode]
			get
			{
				return this._create_audio_rtp_files_button;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.create_audio_rtp_files_button_Click);
				EventHandler value3 = new EventHandler(this.create_raw_file_Click);
				bool flag = this._create_audio_rtp_files_button != null;
				if (flag)
				{
					this._create_audio_rtp_files_button.Click -= value2;
					this._create_audio_rtp_files_button.Click -= value3;
				}
				this._create_audio_rtp_files_button = value;
				flag = (this._create_audio_rtp_files_button != null);
				if (flag)
				{
					this._create_audio_rtp_files_button.Click += value2;
					this._create_audio_rtp_files_button.Click += value3;
				}
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005250 File Offset: 0x00003650
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = this.Text + " Created: " + Conversions.ToString(File.GetLastWriteTime(Application.ExecutablePath));
			this.create_raw_file_button.Enabled = false;
			this.create_merged_file_button.Enabled = false;
			this.source_ip1.Items.Add("All Addresses");
			this.destination_ip1.Items.Add("All Addresses");
			this.source_ip1.SelectedIndex = 0;
			this.destination_ip1.SelectedIndex = 0;
			this.source_ip2.Items.Add("All Addresses");
			this.destination_ip2.Items.Add("All Addresses");
			this.source_ip2.SelectedIndex = 0;
			this.destination_ip2.SelectedIndex = 0;
			this.packet_type.SelectedIndex = 0;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005338 File Offset: 0x00003738
		public void selectfile_Click(object sender, EventArgs e)
		{
			this.dummy_button.Focus();
			this.analyse_file.Enabled = false;
			this.source_ip1.Enabled = false;
			this.destination_ip1.Enabled = false;
			this.source_ip2.Enabled = false;
			this.destination_ip2.Enabled = false;
			this.folder_selected_textbox.Text = "";
			this.raw_output_file_textbox.Text = "";
			this.merged_output_file_textbox.Text = "";
			this.rtp_status.Text = "";
			this.raw_rtp_output_folder.Text = "";
			this.source_ip1.Items.Clear();
			this.source_ip1.Items.Add("All Addresses");
			this.destination_ip1.Items.Clear();
			this.destination_ip1.Items.Add("All Addresses");
			this.source_ip1.SelectedIndex = 0;
			this.destination_ip1.SelectedIndex = 0;
			this.source_ip2.Items.Clear();
			this.source_ip2.Items.Add("All Addresses");
			this.destination_ip2.Items.Clear();
			this.destination_ip2.Items.Add("All Addresses");
			this.source_ip2.SelectedIndex = 0;
			this.destination_ip2.SelectedIndex = 0;
			this.packet_type.SelectedIndex = 0;
			try
			{
				this.OpenFileDialog1.Filter = "Wireshark .pcap files|*.pcap";
				this.OpenFileDialog1.FileName = string.Empty;
				bool flag = this.OpenFileDialog1.ShowDialog() > DialogResult.None;
				if (/*true)/*/flag)
				{
					bool flag2 = Operators.CompareString(this.OpenFileDialog1.FileName, string.Empty, false) != 0;
					if (flag2)
					{
						this.file_selected_textbox.Text = this.OpenFileDialog1.FileName;
                        //thay thế lệnh này = gán trực tiếp từ bên ngoài, các hoạt động config ko thay đổi, vẫn gọi
						int num = Strings.InStr(this.file_selected_textbox.Text, ".", CompareMethod.Binary);
						int length = this.file_selected_textbox.Text.Length;
						string str = Strings.Left(this.file_selected_textbox.Text, num);
						this.raw_output_file_textbox.Text = str + "bin";
						this.create_raw_file_button.Enabled = true;
						str = Strings.Left(this.file_selected_textbox.Text, checked(num - 1));
						this.merged_output_file_textbox.Text = str + "_merged.pcap";
						this.create_merged_file_button.Enabled = true;
						num = Strings.InStrRev(this.file_selected_textbox.Text, "\\", -1, CompareMethod.Binary);
						str = Strings.Left(this.file_selected_textbox.Text, num);
						this.raw_rtp_output_folder.Text = str + "rtp";
						this.analyse_file.Enabled = true;
						this.detect_rtp.Enabled = true;
						this.update_status("File Selected");
						this.dummy_button.Focus();
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning");
				this.create_raw_file_button.Enabled = false;
				this.create_merged_file_button.Enabled = false;
				this.selectfile_button.Enabled = true;
				this.selectfolder_button.Enabled = true;
			}
		}

        public void use_current_file( string current_file_path , EventArgs e)
		{
			this.dummy_button.Focus();
			this.analyse_file.Enabled = false;
			this.source_ip1.Enabled = false;
			this.destination_ip1.Enabled = false;
			this.source_ip2.Enabled = false;
			this.destination_ip2.Enabled = false;
			this.folder_selected_textbox.Text = "";
			this.raw_output_file_textbox.Text = "";
			this.merged_output_file_textbox.Text = "";
			this.rtp_status.Text = "";
			this.raw_rtp_output_folder.Text = "";
			this.source_ip1.Items.Clear();
			this.source_ip1.Items.Add("All Addresses");
			this.destination_ip1.Items.Clear();
			this.destination_ip1.Items.Add("All Addresses");
			this.source_ip1.SelectedIndex = 0;
			this.destination_ip1.SelectedIndex = 0;
			this.source_ip2.Items.Clear();
			this.source_ip2.Items.Add("All Addresses");
			this.destination_ip2.Items.Clear();
			this.destination_ip2.Items.Add("All Addresses");
			this.source_ip2.SelectedIndex = 0;
			this.destination_ip2.SelectedIndex = 0;
			this.packet_type.SelectedIndex = 0;
			try
			{
                //this.OpenFileDialog1.Filter = "Wireshark .pcap files|*.pcap";
                //this.OpenFileDialog1.FileName = string.Empty;
                int flag = current_file_path.Length; //this.OpenFileDialog1.ShowDialog() > DialogResult.None;
				if (flag > 0)
				{
                    //bool flag2 = Operators.CompareString(this.OpenFileDialog1.FileName, string.Empty, false) != 0;
                    //if (flag2)
                    //{
                    this.file_selected_textbox.Text = current_file_path;//this.OpenFileDialog1.FileName;
                        
					int num = Strings.InStr(this.file_selected_textbox.Text, ".", CompareMethod.Binary);
					int length = this.file_selected_textbox.Text.Length;
					string str = Strings.Left(this.file_selected_textbox.Text, num);
					this.raw_output_file_textbox.Text = str + "bin";
					this.create_raw_file_button.Enabled = true;
					str = Strings.Left(this.file_selected_textbox.Text, checked(num - 1));
					this.merged_output_file_textbox.Text = str + "_merged.pcap";
					this.create_merged_file_button.Enabled = true;
					num = Strings.InStrRev(this.file_selected_textbox.Text, "\\", -1, CompareMethod.Binary);
					str = Strings.Left(this.file_selected_textbox.Text, num);
					this.raw_rtp_output_folder.Text = str + "rtp";
					this.analyse_file.Enabled = true;
					this.detect_rtp.Enabled = true;
					this.update_status("File Selected");
					this.dummy_button.Focus();
					
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning");
				this.create_raw_file_button.Enabled = false;
				this.create_merged_file_button.Enabled = false;
				this.selectfile_button.Enabled = true;
				this.selectfolder_button.Enabled = true;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000056BC File Offset: 0x00003ABC
		public void selectfolder_button_Click(object sender, EventArgs e)
		{
			this.disable_buttons();
			this.source_ip1.Enabled = false;
			this.destination_ip1.Enabled = false;
			this.source_ip2.Enabled = false;
			this.destination_ip2.Enabled = false;
			//this.file_selected_textbox.Text = "";
			this.raw_output_file_textbox.Text = "";
			this.raw_rtp_output_folder.Text = "";
			this.rtp_status.Text = "";
			this.source_ip1.Items.Clear();
			this.source_ip1.Items.Add("All Addresses");
			this.destination_ip1.Items.Clear();
			this.destination_ip1.Items.Add("All Addresses");
			this.source_ip1.SelectedIndex = 0;
			this.destination_ip1.SelectedIndex = 0;
			this.packet_type.SelectedIndex = 0;
			try
			{
				bool flag = this.FolderBrowserDialog1.ShowDialog() > DialogResult.None;
				if (flag)
				{
					this.folder_selected_textbox.Text = this.FolderBrowserDialog1.SelectedPath;
					flag = (Strings.Len(this.FolderBrowserDialog1.SelectedPath) > 0);
					if (flag)
					{
						string[] files = Directory.GetFiles(this.folder_selected_textbox.Text, "*.pcap", SearchOption.TopDirectoryOnly);
						flag = (files.Length > 0);
						if (flag)
						{
							this.raw_output_file_textbox.Text = this.folder_selected_textbox.Text + "\\output.bin";
							this.create_raw_file_button.Enabled = true;
							this.merged_output_file_textbox.Text = this.folder_selected_textbox.Text + "\\merged.pcap";
							this.create_merged_file_button.Enabled = true;
							this.raw_rtp_output_folder.Text = this.folder_selected_textbox.Text + "rtp";
							this.analyse_file.Enabled = true;
							this.detect_rtp.Enabled = true;
							this.update_status("Folder Selected");
						}
						else
						{
							Interaction.MsgBox("No .pcap files in selected folder", MsgBoxStyle.Critical, "Warning");
							this.create_raw_file_button.Enabled = false;
							this.dummy_button.Focus();
						}
					}
				}
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Warning");
				this.create_raw_file_button.Enabled = false;
				this.selectfile_button.Enabled = true;
				this.selectfolder_button.Enabled = true;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005968 File Offset: 0x00003D68
		public void create_raw_file_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.dummy_button.Focus();
					this.clear_booleans();
					this.old_file = "";
					Button button = (Button)sender;
					bool flag = Operators.CompareString(button.Name, "analyse_file", false) == 0;
					if (flag)
					{
						this.analyse = true;
					}
					flag = (Operators.CompareString(button.Name, "create_merged_file_button", false) == 0);
					if (flag)
					{
						this.pcap = true;
					}
					flag = (Operators.CompareString(button.Name, "detect_rtp", false) == 0);
					if (flag)
					{
						this.analyse = true;
						this.rtp_analysis = true;
						int num = 0;
						int num2;
						int num3;
						do
						{
							this.rtp_counter[num] = 0;
							num++;
							num2 = num;
							num3 = 10000;
						}
						while (num2 <= num3);
						this.rtp_list.Clear();
					}
					flag = (Operators.CompareString(button.Name, "create_raw_rtp_file_button", false) == 0);
					if (flag)
					{
						this.rtp_write_raw = true;
						flag = !MyProject.Computer.FileSystem.DirectoryExists(this.raw_rtp_output_folder.Text);
						if (flag)
						{
							MyProject.Computer.FileSystem.CreateDirectory(this.raw_rtp_output_folder.Text);
						}
					}
					flag = (Operators.CompareString(button.Name, "create_audio_rtp_files_button", false) == 0);
					if (flag)
					{
						this.rtp_write_raw = true;
						this.rtp_write_audio = true;
						flag = !MyProject.Computer.FileSystem.DirectoryExists(this.raw_rtp_output_folder.Text);
						if (flag)
						{
							MyProject.Computer.FileSystem.CreateDirectory(this.raw_rtp_output_folder.Text);
						}
					}
					this.disable_buttons();
					this.packetcount = 0L;
					flag = this.pcap;
					bool flag2;
					if (flag)
					{
						flag2 = MyProject.Computer.FileSystem.FileExists(this.merged_output_file_textbox.Text);
						if (flag2)
						{
							MyProject.Computer.FileSystem.DeleteFile(this.merged_output_file_textbox.Text);
						}
					}
					else
					{
						flag2 = this.rtp_analysis;
						if (flag2)
						{
							this.header_length.Value = 54m;
							this.payload_offset.Value = 0m;
						}
						else
						{
							flag2 = (this.rtp_write_raw | this.rtp_write_audio);
							if (flag2)
							{
								this.write_rtp_packets();
								flag2 = this.cancelprocessing;
								if (flag2)
								{
									Interaction.MsgBox(this.file_error, MsgBoxStyle.Exclamation, "Warning");
									this.update_status(this.file_error);
								}
								this.enable_buttons();
								this.cancelprocessing = false;
								return;
							}
							flag2 = MyProject.Computer.FileSystem.FileExists(this.raw_output_file_textbox.Text);
							if (flag2)
							{
								MyProject.Computer.FileSystem.DeleteFile(this.raw_output_file_textbox.Text);
							}
						}
					}
					flag2 = (Strings.Len(this.file_selected_textbox.Text) > 0);
					if (flag2)
					{
						this.mybytes = MyProject.Computer.FileSystem.ReadAllBytes(this.file_selected_textbox.Text);
						this.loadpackets(this.file_selected_textbox.Text);
						flag2 = this.cancelprocessing;
						if (flag2)
						{
							Interaction.MsgBox(this.file_error, MsgBoxStyle.Exclamation, "Warning");
							this.update_status(this.file_error);
						}
						else
						{
							this.update_status("File created successfully");
							this.enable_buttons();
						}
					}
					flag2 = (Strings.Len(this.folder_selected_textbox.Text) > 0);
					if (flag2)
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(this.folder_selected_textbox.Text);
						FileInfo[] files = directoryInfo.GetFiles("*.pcap", SearchOption.TopDirectoryOnly);
						foreach (FileInfo fileInfo in files)
						{
							this.mybytes = MyProject.Computer.FileSystem.ReadAllBytes(fileInfo.DirectoryName + "\\" + fileInfo.Name);
							this.loadpackets(fileInfo.DirectoryName + "\\" + fileInfo.Name);
							flag2 = this.cancelprocessing;
							if (flag2)
							{
								break;
							}
						}
						flag2 = this.cancelprocessing;
						if (flag2)
						{
							Interaction.MsgBox(this.file_error, MsgBoxStyle.Exclamation, "Warning");
							this.update_status(this.file_error);
						}
						else
						{
							this.enable_buttons();
							flag2 = this.pcap;
							if (flag2)
							{
								this.update_status("Merged .pcap file created successfully (from folder)");
							}
							else
							{
								this.update_status("File created successfully (from folder)");
							}
						}
					}
					flag2 = this.analyse;
					if (flag2)
					{
						this.update_status("Analysis complete (Packet Count: " + Conversions.ToString(this.packetcount) + ")");
						this.source_ip1.Enabled = true;
						this.destination_ip1.Enabled = true;
						this.source_ip2.Enabled = true;
						this.destination_ip2.Enabled = true;
						this.analyse = false;
						this.source_ip1.SelectedIndex = 0;
						this.destination_ip1.SelectedIndex = 0;
						this.source_ip2.SelectedIndex = 0;
						this.destination_ip2.SelectedIndex = 0;
					}
					flag2 = this.rtp_analysis;
					if (flag2)
					{
						this.detect_rtp.Enabled = true;
						for (;;)
						{
							IL_519:
							flag2 = (this.rtp_list.Count > 0);
							if (flag2)
							{
								this.rtp_stream_count = -1;
								try
								{
									foreach (string text in this.rtp_list)
									{
										string[] array2 = Strings.Split(text, ",", -1, CompareMethod.Binary);
										bool flag3 = false;
										try
										{
											foreach (string expression in this.rtp_list)
											{
												string[] array3 = Strings.Split(expression, ",", -1, CompareMethod.Binary);
												flag2 = (Operators.CompareString(array2[3], array3[4], false) == 0);
												if (flag2)
												{
													flag3 = true;
													this.rtp_stream_count++;
													break;
												}
											}
										}
										finally
										{
											List<string>.Enumerator enumerator2 = new List<string>.Enumerator();
											((IDisposable)enumerator2).Dispose();
										}
										flag2 = !flag3;
										if (flag2)
										{
											this.rtp_list.Remove(text);
											goto IL_519;
										}
									}
								}
								finally
								{
									List<string>.Enumerator enumerator = new List<string>.Enumerator();
									((IDisposable)enumerator).Dispose();
								}
								break;
							}
							goto IL_661;
						}
						this.rtp_status.Text = Conversions.ToString(this.rtp_list.Count) + " RTP streams detected";
						this.create_raw_rtp_file_button.Enabled = true;
						this.create_audio_rtp_files_button.Enabled = true;
						goto IL_68D;
						IL_661:
						this.rtp_status.Text = "No RTP streams detected";
						this.create_raw_rtp_file_button.Enabled = false;
						this.create_audio_rtp_files_button.Enabled = false;
						IL_68D:;
					}
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error Detected");
				}
				this.selectfolder_button.Enabled = true;
				this.selectfile_button.Enabled = true;
				this.create_raw_file_button.Enabled = true;
				this.create_merged_file_button.Enabled = true;
				this.analyse_file.Enabled = true;
				this.dummy_button.Focus();
				this.clear_booleans();
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000060CC File Offset: 0x000044CC
		private void write_rtp_packets()
		{
			bool flag = Strings.Len(this.file_selected_textbox.Text) > 0;
			if (flag)
			{
				this.process_rtp_file();
				this.rtp_status.Text = "RTP streams created (from file)";
				this.update_status("RTP streams created (from file)");
			}
			flag = (Strings.Len(this.folder_selected_textbox.Text) > 0);
			checked
			{
				if (flag)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(this.folder_selected_textbox.Text);
					FileInfo[] files = directoryInfo.GetFiles("*.pcap", SearchOption.TopDirectoryOnly);
					foreach (FileInfo fileInfo in files)
					{
						int num = 0;
						this.mybytes = MyProject.Computer.FileSystem.ReadAllBytes(fileInfo.DirectoryName + "\\" + fileInfo.Name);
						try
						{
							foreach (string text in this.rtp_list)
							{
								flag = (Strings.Len(text) == 0);
								if (flag)
								{
									break;
								}
								this.rtp_status.Text = string.Concat(new string[]
								{
									"Processing RTP stream ",
									Conversions.ToString(num + 1),
									" (",
									fileInfo.Name,
									")"
								});
								num++;
								this.rtp_stream_name = text;
                                
								this.rtp_filename = text.Replace(".", "-");
								this.rtp_filename = this.rtp_filename.Replace(",", "_");
                                Console.WriteLine(this.rtp_stream_name + " -> " + this.rtp_filename);

                                flag = MyProject.Computer.FileSystem.FileExists(this.raw_rtp_output_folder.Text + "\\" + this.rtp_filename + ".bin");
								if (flag)
								{
									MyProject.Computer.FileSystem.DeleteFile(this.raw_rtp_output_folder.Text + "\\" + this.rtp_filename + ".bin");
								}
								this.loadpackets(fileInfo.DirectoryName + "\\" + fileInfo.Name);
								flag = this.cancelprocessing;
								if (flag)
								{
									break;
								}
							}
						}
						finally
						{
							List<string>.Enumerator enumerator = new List<string>.Enumerator();
							((IDisposable)enumerator).Dispose();
						}
						flag = this.cancelprocessing;
						if (flag)
						{
							break;
						}
					}
					this.rtp_status.Text = "RTP streams created (from folder)";
					this.update_status("RTP streams created (from folder)");
				}
				flag = this.rtp_write_audio;
				if (flag)
				{
					this.create_wavfiles();
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000638C File Offset: 0x0000478C
		private void process_rtp_file()
		{
			int num = 0;
			this.mybytes = MyProject.Computer.FileSystem.ReadAllBytes(this.file_selected_textbox.Text);
			checked
			{
				try
				{
					foreach (string text in this.rtp_list)
					{
						bool flag = Strings.Len(text) == 0;
						if (flag)
						{
							break;
						}
						this.rtp_status.Text = "Processing RTP stream " + Conversions.ToString(num + 1);
						num++;
						this.rtp_stream_name = text;
						this.rtp_filename = text.Replace(".", "-");
						this.rtp_filename = this.rtp_filename.Replace(",", "_");
						flag = MyProject.Computer.FileSystem.FileExists(this.raw_rtp_output_folder.Text + "\\" + this.rtp_filename + ".bin");
						if (flag)
						{
							MyProject.Computer.FileSystem.DeleteFile(this.raw_rtp_output_folder.Text + "\\" + this.rtp_filename + ".bin");
						}
						this.loadpackets(this.file_selected_textbox.Text);
						flag = this.cancelprocessing;
						if (flag)
						{
							break;
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator = new List<string>.Enumerator();
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006508 File Offset: 0x00004908
		private void create_wavfiles()
		{
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(this.raw_rtp_output_folder.Text);
				FileInfo[] files = directoryInfo.GetFiles("*.bin", SearchOption.TopDirectoryOnly);
				foreach (FileInfo fileInfo in files)
				{
					this.mybytes = MyProject.Computer.FileSystem.ReadAllBytes(fileInfo.DirectoryName + "\\" + fileInfo.Name);
					int value = 18;
					short value2 = 6;
					short value3 = 1;
					int value4 = 8000;
					short value5 = 1;
					int value6 = 8;
					int value7 = checked(56 + this.mybytes.Length);
					string str = fileInfo.Name.Replace(".bin", ".wav");
					BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileInfo.DirectoryName + "\\" + str, FileMode.Create));
					binaryWriter.Write(1179011410);
					binaryWriter.Write(value7);
					binaryWriter.Write(1163280727);
					binaryWriter.Write(544501094);
					binaryWriter.Write(value);
					binaryWriter.Write(value2);
					binaryWriter.Write(value3);
					binaryWriter.Write(value4);
					binaryWriter.Write(value4);
					binaryWriter.Write(value5);
					binaryWriter.Write(value6);
					binaryWriter.Write(1952670054);
					binaryWriter.Write(4);
					binaryWriter.Write(this.mybytes.Length);
					binaryWriter.Write(1635017060);
					binaryWriter.Write(this.mybytes.Length);
					binaryWriter.Write(this.mybytes, 0, this.mybytes.Length);
					binaryWriter.Close();
					this.update_status("Wave Files Created Successfully");
					this.rtp_status.Text = "Wave Files Created Successfully";
				}
			}
			catch (Exception ex)
			{
				this.update_status("Wav Files Creation Error! (" + ex.Message + ")");
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000672C File Offset: 0x00004B2C
		private void loadpackets(string filename)
		{
			this.update_status("Processing File: " + filename);
			this.dummy_button.Focus();
			this.arraycount = 0;
			FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(filename);
			long length = fileInfo.Length;
			checked
			{
				try
				{
					int num = this.init_wireshark_header + this.normal_wireshark_header;
					int[] array = new int[4];
					int[] array2 = new int[4];
					int[] array3 = new int[4];
					int num2 = Convert.ToInt32(this.header_length.Value);
					int num3 = Convert.ToInt32(this.payload_offset.Value);
					int num4 = 0;
					bool flag = this.pcap;
					string path;
					if (flag)
					{
						path = this.merged_output_file_textbox.Text;
					}
					else
					{
						flag = this.rtp_write_raw;
						if (flag)
						{
							path = this.raw_rtp_output_folder.Text + "\\" + this.rtp_filename + ".bin";
						}
						else
						{
							path = this.raw_output_file_textbox.Text;
						}
					}
					FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
					try
					{
						flag = this.pcap;
						if (flag)
						{
							num = 24;
							num2 = 0;
							num3 = 0;
							num4 = 16;
							flag = (this.packetcount == 0L);
							if (flag)
							{
								fileStream.Write(this.mybytes, 0, this.init_wireshark_header);
							}
						}
						while (this.mybytes.Length - (num + num2 + num3) > 0)
						{
							this.packetcount += 1L;
							array[0] = (int)this.mybytes[num + num4 + 26];
							array[1] = (int)this.mybytes[num + num4 + 27];
							array[2] = (int)this.mybytes[num + num4 + 28];
							array[3] = (int)this.mybytes[num + num4 + 29];
							string text = string.Concat(new string[]
							{
								Conversions.ToString(array[0]),
								".",
								Conversions.ToString(array[1]),
								".",
								Conversions.ToString(array[2]),
								".",
								Conversions.ToString(array[3])
							});
							flag = this.analyse;
							bool flag2;
							if (flag)
							{
								flag2 = !this.source_ip1.Items.Contains(text);
								if (flag2)
								{
									this.source_ip1.Items.Add(text);
									this.source_ip2.Items.Add(text);
								}
							}
							array2[0] = (int)this.mybytes[num + num4 + 30];
							array2[1] = (int)this.mybytes[num + num4 + 31];
							array2[2] = (int)this.mybytes[num + num4 + 32];
							array2[3] = (int)this.mybytes[num + num4 + 33];
							string text2 = string.Concat(new string[]
							{
								Conversions.ToString(array2[0]),
								".",
								Conversions.ToString(array2[1]),
								".",
								Conversions.ToString(array2[2]),
								".",
								Conversions.ToString(array2[3])
							});
							flag2 = this.analyse;
							if (flag2)
							{
								flag = !this.destination_ip1.Items.Contains(text2);
								if (flag)
								{
									this.destination_ip1.Items.Add(text2);
									this.destination_ip2.Items.Add(text2);
								}
							}
							int num5 = (int)(this.mybytes[num - 8 + num4] * 1);
							num5 += (int)this.mybytes[num - 7 + num4] * 256;
							num5 += (int)(this.mybytes[num - 6 + num4] * 16);
							num5 += (int)this.mybytes[num - 5 + num4] * 4096;
							int num6 = num5 - num3 - num2;
							flag2 = this.pcap;
							if (flag2)
							{
								num6 = num5 + this.normal_wireshark_header;
							}
							int offset = num + num2 + num3;
							this.protocol_type = (int)this.mybytes[num + num4 + 23];
							flag2 = (this.protocol_type == 6);
							if (flag2)
							{
								this.protocol_name = "TCP";
							}
							else
							{
								flag2 = (this.protocol_type == 17);
								if (flag2)
								{
									this.protocol_name = "UDP";
									int num7 = (int)this.mybytes[num + num4 + 42];
									flag2 = (num7 == 128);
									if (flag2)
									{
										flag = (this.rtp_analysis | this.rtp_write_raw);
										if (flag)
										{
											this.protocol_name = "RTP";
										}
									}
								}
								else
								{
									this.protocol_name = "INVALID";
								}
							}
							flag2 = this.rtp_analysis;
							if (flag2)
							{
								flag = (Operators.CompareString(this.protocol_name, "RTP", false) == 0);
								if (flag)
								{
									array3[0] = (int)this.mybytes[num + num4 + 50];
									array3[1] = (int)this.mybytes[num + num4 + 51];
									array3[2] = (int)this.mybytes[num + num4 + 52];
									array3[3] = (int)this.mybytes[num + num4 + 53];
									int num8 = (int)this.mybytes[num + num4 + 34] * 256;
									num8 += (int)this.mybytes[num + num4 + 35];
									int num9 = (int)this.mybytes[num + num4 + 36] * 256;
									num9 += (int)this.mybytes[num + num4 + 37];
									string item = string.Concat(new string[]
									{
										text,
										",",
										text2,
										",",
										Conversions.ToString(array3[0]),
										"-",
										Conversions.ToString(array3[1]),
										"-",
										Conversions.ToString(array3[2]),
										"-",
										Conversions.ToString(array3[3]),
										",",
										num8.ToString(),
										",",
										num9.ToString()
									});
									flag2 = (num8 != num9);
									if (flag2)
									{
										flag = !this.rtp_list.Contains(item);
										if (flag)
										{
											this.rtp_list.Add(item);
											int[] array4 = this.rtp_counter;
											int num10 = this.rtp_list.IndexOf(item);
											array4[num10] = this.rtp_counter[num10] + 1;
										}
										else
										{
											int[] array5 = this.rtp_counter;
											int num10 = this.rtp_list.IndexOf(item);
											array5[num10] = this.rtp_counter[num10] + 1;
										}
									}
								}
							}
							flag2 = this.rtp_write_raw;
							if (flag2)
							{
								flag = (Operators.CompareString(this.protocol_name, "RTP", false) == 0);
								if (flag)
								{
									array3[0] = (int)this.mybytes[num + num4 + 50];
									array3[1] = (int)this.mybytes[num + num4 + 51];
									array3[2] = (int)this.mybytes[num + num4 + 52];
									array3[3] = (int)this.mybytes[num + num4 + 53];
									string left = string.Concat(new string[]
									{
										Conversions.ToString(array3[0]),
										"-",
										Conversions.ToString(array3[1]),
										"-",
										Conversions.ToString(array3[2]),
										"-",
										Conversions.ToString(array3[3])
									});
									int num8 = (int)this.mybytes[num + num4 + 34] * 256;
									num8 += (int)this.mybytes[num + num4 + 35];
									int num9 = (int)this.mybytes[num + num4 + 36] * 256;
									num9 += (int)this.mybytes[num + num4 + 37];
									string[] array6 = Strings.Split(this.rtp_stream_name, ",", -1, CompareMethod.Binary);
									this.match_rtp_packet = false;
									this.protocol_name = "INVALID";
									flag2 = (Operators.CompareString(text, array6[0], false) != 0);
									if (!flag2)
									{
										flag2 = (Operators.CompareString(text2, array6[1], false) != 0);
										if (!flag2)
										{
											flag2 = (Operators.CompareString(left, array6[2], false) != 0);
											if (!flag2)
											{
												flag2 = ((double)num8 != Conversion.Val(array6[3]));
												if (!flag2)
												{
													flag2 = ((double)num9 != Conversion.Val(array6[4]));
													if (!flag2)
													{
														this.match_rtp_packet = true;
														flag2 = (num6 > 0);
														if (flag2)
														{
															fileStream.Write(this.mybytes, offset, num6);
														}
													}
												}
											}
										}
									}
								}
							}
							else
							{
								flag2 = !this.analyse;
								if (flag2)
								{
									flag = !this.pcap;
									bool flag3;
									if (flag)
									{
										flag3 = (Strings.InStr(this.packet_type.SelectedItem.ToString(), this.protocol_name, CompareMethod.Binary) == 0);
										if (flag3)
										{
											goto IL_BF9;
										}
									}
									flag3 = (num6 > 0);
									if (flag3)
									{
										flag2 = (Operators.CompareString(this.source_ip1.SelectedItem.ToString(), "All Addresses", false) == 0);
										if (!flag2)
										{
											goto IL_96F;
										}
										flag = (Operators.CompareString(this.destination_ip1.SelectedItem.ToString(), "All Addresses", false) == 0);
										if (!flag)
										{
											goto IL_96F;
										}
										fileStream.Write(this.mybytes, offset, num6);
										IL_A7A:
										flag3 = this.filter2_checkbox.Checked;
										if (flag3)
										{
											flag2 = (Operators.CompareString(this.source_ip2.SelectedItem.ToString(), "All Addresses", false) == 0);
											if (flag2)
											{
												flag = (Operators.CompareString(this.destination_ip2.SelectedItem.ToString(), "All Addresses", false) == 0);
												if (flag)
												{
													fileStream.Write(this.mybytes, offset, num6);
													goto IL_BF9;
												}
											}
											flag3 = (Operators.CompareString(this.source_ip2.SelectedItem.ToString(), text, false) == 0);
											if (flag3)
											{
												flag2 = (Operators.CompareString(this.destination_ip2.SelectedItem.ToString(), "All Addresses", false) == 0);
												if (flag2)
												{
													fileStream.Write(this.mybytes, offset, num6);
													goto IL_BF9;
												}
											}
											flag3 = (Operators.CompareString(this.source_ip2.SelectedItem.ToString(), "All Addresses", false) == 0);
											if (flag3)
											{
												flag2 = (Operators.CompareString(this.destination_ip2.SelectedItem.ToString(), text2, false) == 0);
												if (flag2)
												{
													fileStream.Write(this.mybytes, offset, num6);
													goto IL_BF9;
												}
											}
											flag3 = (Operators.CompareString(this.source_ip2.SelectedItem.ToString(), text, false) == 0);
											if (flag3)
											{
												flag2 = (Operators.CompareString(this.destination_ip2.SelectedItem.ToString(), text2, false) == 0);
												if (flag2)
												{
													fileStream.Write(this.mybytes, offset, num6);
												}
											}
										}
										goto IL_BF9;
										IL_96F:
										flag3 = (Operators.CompareString(this.source_ip1.SelectedItem.ToString(), text, false) == 0);
										if (flag3)
										{
											flag2 = (Operators.CompareString(this.destination_ip1.SelectedItem.ToString(), "All Addresses", false) == 0);
											if (flag2)
											{
												fileStream.Write(this.mybytes, offset, num6);
												goto IL_A7A;
											}
										}
										flag3 = (Operators.CompareString(this.source_ip1.SelectedItem.ToString(), "All Addresses", false) == 0);
										if (flag3)
										{
											flag2 = (Operators.CompareString(this.destination_ip1.SelectedItem.ToString(), text2, false) == 0);
											if (flag2)
											{
												fileStream.Write(this.mybytes, offset, num6);
												goto IL_A7A;
											}
										}
										flag3 = (Operators.CompareString(this.source_ip1.SelectedItem.ToString(), text, false) == 0);
										if (flag3)
										{
											flag2 = (Operators.CompareString(this.destination_ip1.SelectedItem.ToString(), text2, false) == 0);
											if (flag2)
											{
												fileStream.Write(this.mybytes, offset, num6);
											}
										}
										goto IL_A7A;
									}
								}
							}
							IL_BFB:
							num += this.normal_wireshark_header + num5;
							continue;
							IL_BFA:
							goto IL_BFB;
							IL_BF9:
							goto IL_BFA;
						}
					}
					finally
					{
						bool flag3 = fileStream != null;
						if (flag3)
						{
							((IDisposable)fileStream).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					this.file_error = ex.Message + "(" + Conversions.ToString(this.packetcount) + ")";
					this.cancelprocessing = true;
				}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000073F4 File Offset: 0x000057F4
		private void update_status(string update)
		{
			this.current_status_label.Text = update;
			Application.DoEvents();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000740C File Offset: 0x0000580C
		private void raw_output_file_textbox_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.raw_output_file_textbox.Text.Length < 1;
			if (flag)
			{
				bool enabled = this.create_raw_file_button.Enabled;
				if (enabled)
				{
					this.create_raw_file_button.Enabled = false;
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007450 File Offset: 0x00005850
		private void merged_output_file_textbox_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.merged_output_file_textbox.Text.Length < 1;
			if (flag)
			{
				bool enabled = this.create_merged_file_button.Enabled;
				if (enabled)
				{
					this.create_merged_file_button.Enabled = false;
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00007494 File Offset: 0x00005894
		private void disable_buttons()
		{
			this.selectfolder_button.Enabled = false;
			this.selectfile_button.Enabled = false;
			this.create_raw_file_button.Enabled = false;
			this.create_merged_file_button.Enabled = false;
			this.analyse_file.Enabled = false;
			this.detect_rtp.Enabled = false;
			this.create_raw_rtp_file_button.Enabled = false;
			this.create_audio_rtp_files_button.Enabled = false;
			this.cancelprocessing = false;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00007514 File Offset: 0x00005914
		private void enable_buttons()
		{
			this.selectfolder_button.Enabled = true;
			this.selectfile_button.Enabled = true;
			this.create_raw_file_button.Enabled = true;
			this.create_merged_file_button.Enabled = true;
			this.analyse_file.Enabled = true;
			this.detect_rtp.Enabled = true;
			bool flag = Strings.Len(this.rtp_status.Text) > 0;
			if (flag)
			{
				bool flag2 = Strings.InStr(this.rtp_status.Text, "No", CompareMethod.Binary) == 0;
				if (flag2)
				{
					this.create_raw_rtp_file_button.Enabled = true;
					this.create_audio_rtp_files_button.Enabled = true;
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000075C4 File Offset: 0x000059C4
		private void clear_booleans()
		{
			this.analyse = false;
			this.pcap = false;
			this.rtp_analysis = false;
			this.rtp_write_raw = false;
			this.rtp_write_audio = false;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000075EC File Offset: 0x000059EC
		public void create_audio_rtp_files_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400000A RID: 10
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400000C RID: 12
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x0400000D RID: 13
		[AccessedThroughProperty("selectfile_button")]
		private Button _selectfile_button;

		// Token: 0x0400000E RID: 14
		[AccessedThroughProperty("file_selected_textbox")]
		private TextBox _file_selected_textbox;

		// Token: 0x0400000F RID: 15
		[AccessedThroughProperty("raw_output_file_textbox")]
		private TextBox _raw_output_file_textbox;

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("create_raw_file_button")]
		private Button _create_raw_file_button;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("current_status_label")]
		private Label _current_status_label;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("dummy_button")]
		private Button _dummy_button;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("selectfolder_button")]
		private Button _selectfolder_button;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("folder_selected_textbox")]
		private TextBox _folder_selected_textbox;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("payload_offset")]
		private NumericUpDown _payload_offset;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("header_length")]
		private NumericUpDown _header_length;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("analyse_file")]
		private Button _analyse_file;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("destination_ip1")]
		private ComboBox _destination_ip1;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("source_ip1")]
		private ComboBox _source_ip1;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("destination_ip2")]
		private ComboBox _destination_ip2;

		// Token: 0x0400002A RID: 42
		[AccessedThroughProperty("source_ip2")]
		private ComboBox _source_ip2;

		// Token: 0x0400002B RID: 43
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x0400002C RID: 44
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x0400002D RID: 45
		[AccessedThroughProperty("filter2_checkbox")]
		private CheckBox _filter2_checkbox;

		// Token: 0x0400002E RID: 46
		[AccessedThroughProperty("packet_type")]
		private ComboBox _packet_type;

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("merged_output_file_textbox")]
		private TextBox _merged_output_file_textbox;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("create_merged_file_button")]
		private Button _create_merged_file_button;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("raw_rtp_output_folder")]
		private TextBox _raw_rtp_output_folder;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000037 RID: 55
		[AccessedThroughProperty("create_raw_rtp_file_button")]
		private Button _create_raw_rtp_file_button;

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("detect_rtp")]
		private Button _detect_rtp;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("rtp_status")]
		private TextBox _rtp_status;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("create_audio_rtp_files_button")]
		private Button _create_audio_rtp_files_button;

		// Token: 0x0400003C RID: 60
		private int arraycount;

		// Token: 0x0400003D RID: 61
		private string closingwords;

		// Token: 0x0400003E RID: 62
		private int matchcount;

		// Token: 0x0400003F RID: 63
		private string filecontents;

		// Token: 0x04000040 RID: 64
		private bool cancelprocessing;

		// Token: 0x04000041 RID: 65
		private string file_error;

		// Token: 0x04000042 RID: 66
		private bool analyse;

		// Token: 0x04000043 RID: 67
		private bool pcap;

		// Token: 0x04000044 RID: 68
		private bool rtp_analysis;

		// Token: 0x04000045 RID: 69
		private bool rtp_write_raw;

		// Token: 0x04000046 RID: 70
		private bool rtp_write_audio;

		// Token: 0x04000047 RID: 71
		private int[] rtp_counter;

		// Token: 0x04000048 RID: 72
		public List<string> rtp_list;

		// Token: 0x04000049 RID: 73
		private List<string> rtp_source_port;

		// Token: 0x0400004A RID: 74
		private List<string> rtp_destination_port;

		// Token: 0x0400004B RID: 75
		private int rtp_stream_count;

		// Token: 0x0400004C RID: 76
		private string rtp_stream_name;

		// Token: 0x0400004D RID: 77
		private bool match_rtp_packet;

		// Token: 0x0400004E RID: 78
		private string rtp_filename;

		// Token: 0x0400004F RID: 79
		private long packetcount;

		// Token: 0x04000050 RID: 80
		private int protocol_type;

		// Token: 0x04000051 RID: 81
		private string protocol_name;

		// Token: 0x04000052 RID: 82
		private string old_file;

		// Token: 0x04000053 RID: 83
		private bool file_loaded;

		// Token: 0x04000054 RID: 84
		private byte[] mybytes;

		// Token: 0x04000055 RID: 85
		private int init_wireshark_header;

		// Token: 0x04000056 RID: 86
		private int normal_wireshark_header;
	}
}
