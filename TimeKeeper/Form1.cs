namespace TimeKeeper
{
    public partial class Form_Main : Form
    {
        // time_keeper_datas
        Dictionary<DateTime, List<TimeKeeperData>> time_keeper_dict;

        //　コンストラクタ
        public Form_Main()
        {
            InitializeComponent();
            time_keeper_dict = new Dictionary<DateTime, List<TimeKeeperData>>();
        }

        // 再帰ファイルスキャン
        public void file_scaning(DirectoryInfo dir)
        {
            var files = dir.GetFiles();
            var dirs = dir.GetDirectories();

            foreach (var file in files)
            {
                var time_keeper_data = new TimeKeeperData(file);
                if (!time_keeper_dict.ContainsKey(time_keeper_data.date_data))
                {
                    time_keeper_dict[time_keeper_data.date_data]
                        = new List<TimeKeeperData>();

                    time_keeper_dict[time_keeper_data.date_data]
                        .Add(time_keeper_data);

                }
                else
                {
                    time_keeper_dict[time_keeper_data.date_data]
                        .Add(time_keeper_data);
                }

            }

            if (dirs.Length == 0)
            {
                return;
            }
            else
            {
                foreach (var src_dir in dirs)
                {
                    file_scaning(src_dir);
                }
            }
        }

        // ボタンクリック
        private void btn_start_Click(object sender, EventArgs e)
        {
            DGV_day_file_time.Rows.Clear();
            string dir_path = TB_Path.Text;
            if (!Directory.Exists(dir_path)){
                MessageBox.Show("入力されたパスのディレクトリはありません");
                return; }
            file_scaning(new DirectoryInfo(TB_Path.Text));
            List<DateTime> time_keer_dict_keys = time_keeper_dict.Keys.ToList();
            time_keer_dict_keys.Sort();

            foreach (DateTime k in time_keer_dict_keys)
            {
                // その日作ったファイルのリスト
                var file_create_day_lst = time_keeper_dict[k];
                file_create_day_lst.Sort();
                var last_create_file_day = file_create_day_lst[file_create_day_lst.Count - 1];
                DGV_day_file_time.Rows.Add(
                    last_create_file_day.date_data.ToString(),
                    last_create_file_day.file_name,
                    last_create_file_day.time_span.Hours.ToString().PadLeft(2, '0') + ":"
                        + last_create_file_day.time_span.Minutes.ToString().PadLeft(2, '0'));

            }
            DGV_day_file_time.Invalidate();
        }


        private void DGV_day_file_time_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_PerDay.Rows.Clear();
            var i = e.RowIndex;
            var cell = DGV_day_file_time[0, i];
            var val = cell.Value.ToString();
            var date_lst = val.Split("/");

            var lst_day_data = time_keeper_dict[new DateTime(int.Parse(date_lst[0]), int.Parse(date_lst[1]), int.Parse(date_lst[2].Split(" ")[0]))];
            lst_day_data.Sort();


            foreach (var day_data in lst_day_data)
            {
                DGV_PerDay.Rows.Add(
                        day_data.file_name,
                        day_data.write_time
                    );
            }

            DGV_PerDay.Invalidate();
        }
    }
}