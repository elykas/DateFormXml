using static DateFormXml.Service.DateService;
namespace DateFormXml
{
    public partial class Form1 : Form
    {
        List<string> _listDayOfWeek;
        List<int> _listDateOfMOnth;
        List<string> _listMonth;
        List<string> _listYear;
        public Form1()
        {
            InitializeComponent();
            CreateXml();
            _listDayOfWeek = ["ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי"];
            _listDateOfMOnth = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
                             , 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30];
            _listMonth = ["תשרי", "חשון", "כסלו", "טבת", "שבט", "אדר א", "אדר ב", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול"];
            _listYear = [@" תשפ""ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג"];
            DateWeekComboBox.DataSource = _listDayOfWeek.ToList();
            DateMonthComboBox.DataSource = _listDateOfMOnth.ToList();
            MonthComboBox.DataSource = _listMonth.ToList();
            YearComboBox.DataSource = _listYear.ToList();


        }

        public string getStringDateWeek()
        {
            string dayWeek = DateWeekComboBox.Text;
            string result = "";
            switch (dayWeek)
            {
                case "ראשון":
                    result = "באחד בשבת";
                    break;
                case "שני":
                    result = "בשני בשבת";
                    break;
                case "שלישי":
                    result = "בשלישי בשבת";
                    break;
                case "רביעי":
                    result = "ברביעי בשבת";
                    break;
                case "חמישי":
                    result = "בחמישי בשבת";
                    break;
                case "שישי":
                    result = "בששי בשבת";
                    break;
            }
            return result;
        }


        public string GetStringDayMaonth()
        {
            int dayMonth = DateMonthComboBox.SelectedIndex;
            string result = "";

            switch (dayMonth)
            {
                case 1: result = "יום אחד לירח "; break;
                case 2: result = "שני ימים לירח "; break;
                case 3: result = "שלשה ימים לירח "; break;
                case 4: result = "ארבעה ימים לירח "; break;
                case 5: result = "חמשה ימים לירח "; break;
                case 6: result = "ששה ימים לירח "; break;
                case 7: result = "שבעה ימים לירח "; break;
                case 8: result = "שמנה ימים לירח "; break;
                case 9: result = "תשעה ימים לירח "; break;
                case 10: result = "אחד עשר יום לירח "; break;
                case 11: result = "שנים עשר יום לירח "; break;
                case 12: result = "שלשה עשר יום לירח "; break;
                case 13: result = "ארבעה עשר יום לירח "; break;
                case 14: result = "חמשה עשר יום לירח "; break;
                case 15: result = "ששה עשר יום לירח "; break;
                case 16: result = "שבעה עשר יום לירח "; break;
                case 17: result = "שמנה עשר יום לירח "; break;
                case 18: result = "תשעה עשר יום לירח "; break;
                case 19: result = "עשרים יום לירח "; break;
                case 20: result = "עשרים ואחד יום לירח "; break;
                case 21: result = "שנים ועשרים יום לירח "; break;
                case 22: result = "שלשה ועשרים יום לירח "; break;
                case 23: result = "ארבעה ועשרים יום לירח "; break;
                case 24: result = "חמשה ועשרים יום לירח "; break;
                case 26: result = "ששה ועשרים יום לירח "; break;
                case 27: result = "שבעה ועשרים יום לירח "; break;
                case 28: result = "שמנה ועשרים יום לירח "; break;
                case 29: result = "תשעה ועשרים יום לירח "; break;
                case 30: result = " יום שלשים לירח שהוא ראש חודש  "; break;
            }
            return result;
        }

        public string GetStringYear()
        {
            string year = YearComboBox.Text;
            string result = string.Empty;

            switch (year)
            {
                case "תשפ\"ד":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשפ\"ה":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשפ\"ו":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשפ\"ז":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשפ\"ח":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשפ\"ט":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשצ":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשפ\"א":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשצ\"ב":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
                case "תשצ\"ג":
                    result = "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם"; break;
            }
            return result;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string dayWeekString = getStringDateWeek();
            string dayWeek = DateWeekComboBox.Text;
            int dayMonth = DateMonthComboBox.SelectedIndex;
            string dayMonthString = GetStringDayMaonth();
            string month = MonthComboBox.Text;
            string year = YearComboBox.Text;
            string yearString = GetStringYear();
            string result = $"{dayWeekString} {dayMonthString} {month} {yearString}";

            AddDate(dayWeek, dayMonth, month, year, result);
            MessageBox.Show($"{result}");
        }


    }
}

