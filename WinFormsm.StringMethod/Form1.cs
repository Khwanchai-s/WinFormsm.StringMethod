namespace WinFormsm.StringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullName="", firstname="", lastname="", title="";
            int x = 0;
            //�ӨѴ Space ˹���ش�����ѧ�ش�͡
            fullName = txtFullName.Text.Trim();
            //��Ǩ�ͺ����դӹ�˹�ҷ���ͧ���������� "�ҧ���", "�ҧ", "���"
            //�Ѵ�ӹ�˹�� �͡��ʴ��� 
            if (fullName.StartsWith("�ҧ���")) 
            {
                x = 6;        //���˹觷���ͧ����¡
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("�ҧ")|| fullName.StartsWith("���"))
            {
                x = 3;         //���˹觷���ͧ����¡
                title = fullName.Substring(0, x);
            }
            fullName = fullName.Substring(x).Trim();

            //�ҵ��˹觪�ͧ��ҧ�����ҧ�������ʡ��
            x = fullName.IndexOf(" ");
            //�Ѵ������Ƿ�� 0 ���֧���˹觪�ͧ��ҧ�������
            firstname = fullName.Substring(0, x).Trim();
            //�Ѵ�������˹觪�ͧ��ҧ 仨������ͤ���������ʡ��
            lastname = fullName.Substring(x).Trim();

            //�ʴ���� Textbox
            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname;
        }
    }
}
