using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper
{
    internal class TimeKeeperData : IComparable
    {

        public DateTime date_data;
        public string file_name;
        public TimeSpan time_span;
        public DateTime write_time;

        // コンストラクタ
        public TimeKeeperData(FileInfo file_info)
        {
            // 日付
            var last_write_time = file_info.LastWriteTime;
            write_time = last_write_time;

            date_data =
                new DateTime(last_write_time.Year, last_write_time.Month, last_write_time.Day);

            file_name = file_info.Name;

            // 最終ファイル書き込み時間
            var today_time = file_info.LastWriteTime;

            // 始業時間
            var work_start_time = new DateTime(
                today_time.Year,
                today_time.Month,
                today_time.Day,
                11,00,00
                );
            time_span = today_time - work_start_time;
        }

        // コンペア
        public int CompareTo(object? other_class)
        {
            var other_keeper = other_class as TimeKeeperData;
            // ヌルチェック
            if( other_keeper == null ) {
                throw new ArgumentException("null object exception");
            }

            return time_span.CompareTo(other_keeper.time_span); 
        }
    }
}
