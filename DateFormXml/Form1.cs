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
            _listDayOfWeek = ["�����", "���", "�����", "�����", "�����", "����"];
            _listDateOfMOnth = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
                             , 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30];
            _listMonth = ["����", "����", "����", "���", "���", "��� �", "��� �", "����", "����", "����", "����", "��", "����"];
            _listYear = [@" ���""�", "���\"�", "���\"�", "���\"�", "���\"�", "���\"�", "��\"�", "���\"�", "���\"�", "���\"�"];
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
                case "�����":
                    result = "���� ����";
                    break;
                case "���":
                    result = "���� ����";
                    break;
                case "�����":
                    result = "������ ����";
                    break;
                case "�����":
                    result = "������ ����";
                    break;
                case "�����":
                    result = "������ ����";
                    break;
                case "����":
                    result = "���� ����";
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
                case 1: result = "��� ��� ���� "; break;
                case 2: result = "��� ���� ���� "; break;
                case 3: result = "���� ���� ���� "; break;
                case 4: result = "����� ���� ���� "; break;
                case 5: result = "���� ���� ���� "; break;
                case 6: result = "��� ���� ���� "; break;
                case 7: result = "���� ���� ���� "; break;
                case 8: result = "���� ���� ���� "; break;
                case 9: result = "���� ���� ���� "; break;
                case 10: result = "��� ��� ��� ���� "; break;
                case 11: result = "���� ��� ��� ���� "; break;
                case 12: result = "���� ��� ��� ���� "; break;
                case 13: result = "����� ��� ��� ���� "; break;
                case 14: result = "���� ��� ��� ���� "; break;
                case 15: result = "��� ��� ��� ���� "; break;
                case 16: result = "���� ��� ��� ���� "; break;
                case 17: result = "���� ��� ��� ���� "; break;
                case 18: result = "���� ��� ��� ���� "; break;
                case 19: result = "����� ��� ���� "; break;
                case 20: result = "����� ���� ��� ���� "; break;
                case 21: result = "���� ������ ��� ���� "; break;
                case 22: result = "���� ������ ��� ���� "; break;
                case 23: result = "����� ������ ��� ���� "; break;
                case 24: result = "���� ������ ��� ���� "; break;
                case 26: result = "��� ������ ��� ���� "; break;
                case 27: result = "���� ������ ��� ���� "; break;
                case 28: result = "���� ������ ��� ���� "; break;
                case 29: result = "���� ������ ��� ���� "; break;
                case 30: result = " ��� ����� ���� ���� ��� ����  "; break;
            }
            return result;
        }

        public string GetStringYear()
        {
            string year = YearComboBox.Text;
            string result = string.Empty;

            switch (year)
            {
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
                case "���\"�":
                    result = "���� ���� ����� ���� ���� ������ ����� ������ �����"; break;
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

