using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace 日本語ミニテスト
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionNumbers= new List<int> {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34};
        int qNum = 0;
        int i;
        int score;
        int scorenp;
        int scoretv;
        int st=0;
        int phut = 0;
        int scorewr;
      

        public MainWindow()
        {
            InitializeComponent();
           
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
            if (senderButton.Tag.ToString() == "2")
            {
                scorenp++;
            }
            if (senderButton.Tag.ToString() == "3")
            {
                scoretv++;
            } 
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            { 
                qNum++;
            }
            scoreText.Content = "会話 :" + score + "/" + "10";
            scoreText1.Content = "文法 :" + scorenp + "/" + "10";
            scoreText2.Content = "語彙 :" + scoretv + "/" + "10";
            scoreText3.Content = "書く点数 :" + scorewr + "/" + "20";
            NextQuestion();
        }
        private void RSgame() 
        {
            score = 0;
            qNum = -1;
            i = 0;
            st = 0;
            increment = 0;
            phut = 0;
            TimerLabel1.Content = "0";
        }
        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count && st>0)
            {
                i = questionNumbers[qNum];
            }
            if(qNum==questionNumbers.Count)
            {
                int diem;
                diem = score + scorenp + scoretv + scorewr;
                MessageBox.Show("Tong so diem cua ban la : " + "" +
                "会話 :" + score + "/" + "10" +"  "+
                "文法 :" + scorenp + "/" + "10" + "  " +
                "語彙 :" + scoretv + "/" + "10" + "  " +
                "書く点数 :" + scorewr + "/" + "20" +"\n" + "\n"        +     "                                       " + "Tổng điểm bài test của bạn là : " + diem+"/50");
               
                 
                RSgame();
            }
            if (phut == 45) {
                MessageBox.Show("Tong so diem cua ban la : " + score);
                RSgame();
            }
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.White;
            }
            switch (i)
            {
                case 0:
                    questionOrder.Content = "STARGAME";

                    txtQuestion.Text = "Ấn StarGame hoặc ^.^ rồi trọn một nguyện vọng khi làm bài của bạn ?";

                    ans1.Content = "Tôi sẽ cố gắng hết mình ";
                    ans2.Content = "Tôi sẽ làm như mình nghĩ";
                    ans3.Content = "Tôi muốn biết năng lực của mình";
                    ans4.Content = "Bình thường ";
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/0.png"));

                    break;
                case 1:
                    questionOrder.Content = "1";
                    ans7.Content = "^.^";
          
                    txtQuestion.Text = "Bạn sẽ nói gì trong tình huống này ?"; 
                   
                    ans1.Content = "こんちはミンです";
                    ans2.Content = "すみません";
                    ans3.Content = "ありがとうございます";
                    ans4.Content = "いいえ、どうしまして";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.png"));

                    break;
                case 2:
                    questionOrder.Content = "2";
                    ans7.Content = "^.^";

                    txtQuestion.Text = "Sử dụng cấu trúc nói về sở thích ";

                    ans1.Content = "映画を見ます";
                    ans2.Content = "サッカーをすることです";
                    ans3.Content = "歌手です";
                    ans4.Content = "会社員です";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.png"));

                    break;
                case 3:
                    questionOrder.Content = "3";
                    txtQuestion.Text = "Bạn nữ áo đỏ đag muốn đi du lịch ở Asian bạn hãy cho bạn ấy lời khuyên !";

                    ans1.Content = "アジアならシンガポールがきれいですよ";
                    ans2.Content = "タイに行けばよかったのに。";
                    ans3.Content = "一緒にいかない";
                    ans4.Content = "ベトナムに行ったことがあるの";
                    ans1.Tag = "1";
                   
                    

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.png"));

                    break;
                case 4:
                    questionOrder.Content = "4";
                    txtQuestion.Text = "Anh Cố gắng đang muốn hỏi đường trong trường hợp này bạn là anh 強いさんthì bạn sẽ sử dụng ngữ pháp nào?";

                    ans1.Content = "Vて　Vると。。。";
                    ans2.Content = "V たらいいです。。。";
                    ans3.Content = "V なくてもいいです。。。";
                    ans4.Content = "V　たほうがいいです。。。 ";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.png"));

                    break;
                case 5:
                    questionOrder.Content = "5";
                    txtQuestion.Text = "Bạn mèo đang chở rất nhiều cá hãy xin bạn ấy vài con";

                    ans1.Content = "待ってください";
                    ans2.Content = "早く走れ";
                    ans3.Content = "一匹もらってもいい";
                    ans4.Content = "何をしますか";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.png"));

                    break;
                case 6:
                    questionOrder.Content = "6";
                    txtQuestion.Text = "Bạn là người con gái thì bạn sẽ nói gì ?";

                    ans1.Content = "美味しくない";
                    ans2.Content = "ええ。晴れているだ";
                    ans3.Content = "たまらないです";
                    ans4.Content = "涼しいな";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.png"));

                    break;
                case 7:
                    questionOrder.Content = "7";
                    txtQuestion.Text = "Nếu bạn nam nói như trên bạn sẽ trả lời như thế nào";

                    ans1.Content = "ああ　いけません";
                    ans2.Content = "ええ　行きましょ。";
                    ans3.Content = "わかりました";
                    ans4.Content = "何ですか";
                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/7.png"));

                    break;
                case 8:
                    questionOrder.Content = "8";
                    txtQuestion.Text = "Bạn vừa đến nhật và được hỏi về cuộc sống hiện tại ";

                    ans1.Content = "行きませんですね";
                    ans2.Content = "日本語が話せるようになった";
                    ans3.Content = "はい　もうなれました";
                    ans4.Content = "いいえ　帰りません";
                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/8.png"));

                    break;
                case 9:
                    questionOrder.Content = "9";
                    txtQuestion.Text = "Bạn sẽ trả lời gì khi được bạn nam hỏi đường";

                    ans1.Content = "地図を書いてあげるね";
                    ans2.Content = "いいえ　何もありません";
                    ans3.Content = "好きです";
                    ans4.Content = "あの車はいいですね";
                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/9.png"));

                    break;
                case 10:
                    questionOrder.Content = "10";
                    txtQuestion.Text = "Chị gái kia muốn biết bạn cảm thấy  như thế nào";

                    ans1.Content = "銀行員です";
                    ans2.Content = "何もありません";
                    ans3.Content = "大変ですが、おもしろいです";
                    ans4.Content = "たまらないです";
                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/10.png"));

                    break;

                case 11:
                    questionOrder.Content = "11";
                    txtQuestion.Text = "Dùng cấu trúc ở đâu có cái gì để trọn đáp án";

                    ans1.Content = "びんがあります";
                    ans2.Content = "ケーキがあります";
                    ans3.Content = "花のびんとケーキがあります";
                    ans4.Content = "テーブルにケーキと花のびんがある";
                    ans4.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/11.png"));

                    break;
                case 12:
                    questionOrder.Content = "12";
                    txtQuestion.Text = "Hay miêu tả vị trí và trạng thái của 2 người kia";

                    ans1.Content = "木下の二人";
                    ans2.Content = "木の上に話してる二人";
                    ans3.Content = "恋してる二人";
                    ans4.Content = "木の下に座ってる二人";
                    ans4.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/12.png"));

                    break;
                case 13:
                    questionOrder.Content = "13";
                    txtQuestion.Text = "Đây là một tràng thiếu niên rất nổi tiếng hãy cho biết câu anh ấy hay nói nhấtー＞ sử dụng cấu trúc bài 19 minna ";
                    ans1.Content = "海賊の男";
                    ans2.Content = "一緒に行こう";
                    ans3.Content = "海賊に俺はなるんだ";
                    ans4.Content = "ああ 疲れた";
                    ans3.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/13.png"));

                    break;
                case 14:
                    questionOrder.Content = "14";
                    txtQuestion.Text = "Hãy dùng cấu trúc định ngữ để trọn đáp án đúng ";

                    ans1.Content = "黒い男の子";
                    ans2.Content = "帽子をかぶる男";
                    ans3.Content = "眼鏡をかける男";
                    ans4.Content = "青い女の子";
                    ans3.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/14.png"));

                    break;
                case 15:
                    questionOrder.Content = "15";
                    txtQuestion.Text = "hãy miêu tả　Công viên này như thế nào ";

                    ans1.Content = "きれいじゃない公園";
                    ans2.Content = "緑が多くて人が沢山いる公園";
                    ans3.Content = "素敵な公園";
                    ans4.Content = "二人が歩いている公園";
                    ans2.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/15.png"));

                    break;
                case 16:
                    questionOrder.Content = "16";
                    txtQuestion.Text = "Chàng trai đang làm gì Bằng cấu trúc cho nhận hãy xác nhận câu trả lời đúng ";

                    ans1.Content = "ギータを引く";
                    ans2.Content = "彼女にギータを引いてあげる";
                    ans3.Content = "笑っています";
                    ans4.Content = "彼女が好きです";
                    ans2.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/16.png"));

                    break;
                case 17:
                    questionOrder.Content = "17";
                    txtQuestion.Text = "Bạn là bạn nam bên phải thì bạn sẽ dùng cấu trúc nào để trả lời ";

                    ans1.Content = "Vてあげる";
                    ans2.Content = "Vないように";
                    ans3.Content = "V とします";
                    ans4.Content = "Vるつもりです";
                    ans4.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/17.png"));

                    break;
                case 18:
                    questionOrder.Content = "18";
                    txtQuestion.Text = "Cấu trúc bạn nam sử dụng có ý nghĩa để ";

                    ans1.Content = "Nói điều mình biết";
                    ans2.Content = "Hình như là ...";
                    ans3.Content = "Thông tin được nghe nói là ...";
                    ans4.Content = "Đúng như là";
                    ans3.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/18.png"));

                    break;
                case 19:
                    questionOrder.Content = "19";
                    txtQuestion.Text = "Hãy sử dụng cấu strúc phán đoán ";

                    ans1.Content = "誰もいませんね";
                    ans2.Content = "誰ももいないようですね";
                    ans3.Content = "誰がありますね";
                    ans4.Content = "誰もいないそうですね";
                    ans2.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/19.png"));

                    break;
                case 20:
                    questionOrder.Content = "20";
                    txtQuestion.Text = "....";

                    ans1.Content = "かどうか";
                    ans2.Content = "教えてください";
                    ans3.Content = "おしえていただけませんか";
                    ans4.Content = "かどうか教えてもらえません";
                    ans4.Tag = "2";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/20.png"));

                    break;
                case 21:
                    questionOrder.Content = "21";
                    txtQuestion.Text = "Mỗi sáng An thường ..";

                    ans1.Content = "寝ます";
                    ans2.Content = "働きます";
                    ans3.Content = "勉強します";
                    ans4.Content = "起きます";
                    ans4.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/21.png"));

                    break;
                case 22:
                    questionOrder.Content = "22";
                    txtQuestion.Text = "Anh Minh mỗi sáng đều ...";

                    ans1.Content = "歩いています";
                    ans2.Content = "笑います";
                    ans3.Content = "ジョギングしています";
                    ans4.Content = "滑ります";
                    ans3.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/22.png"));

                    break;
                case 23:
                    questionOrder.Content = "23";
                    txtQuestion.Text = "Bạn học tiếng nhật để ...";

                    ans1.Content = "日本へ帰ります";
                    ans2.Content = "日本へ行きます";
                    ans3.Content = "日本へ来ました";
                    ans4.Content = "日本に参りました";
                    ans2.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/23.png"));

                    break;
                case 24:
                    questionOrder.Content = "24";
                    txtQuestion.Text = "2 bạn nhỏ đang làm gì nào?";

                    ans1.Content = "けんかします";
                    ans2.Content = "話します";
                    ans3.Content = "テレビを見ます";
                    ans4.Content = "友達になります";
                    ans3.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/24.png"));

                    break;
                case 25:
                    questionOrder.Content = "25";
                    txtQuestion.Text = "Cô gái đang làm gì ";

                    ans1.Content = "勉強しています";
                    ans2.Content = "本を読む";
                    ans3.Content = "寝ます";
                    ans4.Content = "何もしません";
                    ans1.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/25.png"));

                    break;
                case 26:
                    questionOrder.Content = "26";
                    txtQuestion.Text = "三人は何をしていますか";

                    ans1.Content = "お酒を飲んでいます";
                    ans2.Content = "肉を焼きます";
                    ans3.Content = "疲れました";
                    ans4.Content = "何もしていない";
                    ans2.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/26.png"));

                    break;
                case 27:
                    questionOrder.Content = "27";
                    txtQuestion.Text = "二人は何をしていますか";

                    ans1.Content = "泳いています";
                    ans2.Content = "話しています";
                    ans3.Content = "船に乗っています";
                    ans4.Content = "笑っています";
                    ans3.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/27.png"));

                    break;
                case 28:
                    questionOrder.Content = "28";
                    txtQuestion.Text = "この場面はどうしますか";

                    ans1.Content = "何もしません";
                    ans2.Content = "手伝ってはいけない";
                    ans3.Content = "手伝ってください";
                    ans4.Content = "手伝わなければなりません";
                    ans4.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/28.png"));

                    break;
                case 29:
                    questionOrder.Content = "29";
                    txtQuestion.Text = "Có mấy đứa trẻ ";

                    ans1.Content = "子供が一人います";
                    ans2.Content = "子供が五人います";
                    ans3.Content = "子供が二人います";
                    ans4.Content = "子供が二人います";
                    ans2.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/29.png"));

                    break;
                case 30:
                    questionOrder.Content = "30";
                    txtQuestion.Text = "黄色い髪の毛男人は何をしていますか";

                    ans1.Content = "写真をとっています";
                    ans2.Content = "カメラをもっています";
                    ans3.Content = "みんなとパーティーします";
                    ans4.Content = "整理します";
                    ans1.Tag = "3";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/30.png"));

                    break;
                case 31:
                    questionOrder.Content = "31";
                    MessageBox.Show("Các bạn hãy dịch câu hỏi sang tiếng nhật rồi nhập câu  trả lời vào ô trống bên trái rồi ấn submid , ấn >>> nếu muốn bỏ qua　hãy viết bằng kanji nhé");

                    txtQuestion.Text = "(mộtchiếc xe đạp mới)(chiếc xe đạp tôi mượn từ bạn bè)(chiếc xe đạp tôi nhận được vào ngày sinh nhật)";

                    ans1.Content = ">>>";
                    ans2.Content = ">>>";
                    ans3.Content = ">>>";
                    ans4.Content = ">>>";
                    

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/31.png"));

                    break;
                case 32:
                    questionOrder.Content = "32";
                    txtQuestion.Text = " (gặp cô gái dưới gốc cây )";

                    ans1.Content = ">>>";
                    ans2.Content = ">>>";
                    ans3.Content = ">>>";
                    ans4.Content = ">>>";
                    

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/32.png"));

                    break;
                case 33:
                    questionOrder.Content = "33";
                    txtQuestion.Text = "(đây là bộ phim nôi tiếng nhất nhật bản )";

                    ans1.Content = ">>>";
                    ans2.Content = ">>>";
                    ans3.Content = ">>>";
                    ans4.Content = ">>>";
                   

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/33.png"));

                    break;
                case 34:
                    questionOrder.Content = "34";
                    txtQuestion.Text = "(bạn bè tôi đang chăm chỉ học bài )";

                    ans1.Content = ">>>";
                    ans2.Content = ">>>";
                    ans3.Content = ">>>";
                    ans4.Content = "Kết thúc";
                    

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/34.png"));

                    break;



            }
        }
        int kt=0;
        int kt32 = 0;
        int kt33 = 0;
        int kt34 = 0;

        private void checkAnswer2(object sender, RoutedEventArgs e)
        {

            if (kt < 1)
            {
                if (textBoxcheck.Text == "新しい自転車" ||
                    textBoxcheck.Text == "誕生日にもらった自転車" ||
                    textBoxcheck.Text == "友達から借りた自転車" ||
                    textBoxcheck.Text == "自転車が誕生日にもらった" ||
                    textBoxcheck.Text == "自転車が新しいです" ||
                    textBoxcheck.Text == "自転車は友達から借りました")
                {
                    scorewr += 5;
                    kt++;

                }
                
                scoreText3.Content = "書く点数 :" + scorewr + "/" + "20";
                textBoxcheck.Text = null;
            }
            
            if (kt32 < 1)
            {
                if (textBoxcheck.Text == "彼女に木の下で会います" ||
                    textBoxcheck.Text == "木の下で彼女に会います" ||
                    textBoxcheck.Text == "きのしたでかのじょうにあいます")
                {
                    scorewr += 5;
                    kt32++;
           
                }
                
                scoreText3.Content = "書く点数 :" + scorewr + "/" + "20";
                textBoxcheck.Text = null;
            }
            if(kt33 < 1)
            {
                if (textBoxcheck.Text == "korehanihonndeichibanyuumenaeigadesu" || textBoxcheck.Text == "これは日本で一番有名なアニメです" || textBoxcheck.Text == "これは日本で一番有名な映画です")
                {
                    scorewr += 5;
                    kt33++;
                }
                else
                {
                  
                    textBoxcheck.Text = null;
                }
                scoreText3.Content = "書く点数 :" + scorewr + "/" + "20";
                textBoxcheck.Text = null;
            }
            if(kt34 < 1)
            {
                if (textBoxcheck.Text == "私の友達は一生懸命に勉強しています" || textBoxcheck.Text == "私の友達は熱心にに勉強しています" || textBoxcheck.Text == "私の友達が一生懸命に勉強しています")
                {
                    scorewr += 5;
                    kt34++;
                }
                else
                {
                    
                    textBoxcheck.Text = null;

                }
                scoreText3.Content = "書く点数 :" + scorewr + "/" + "20";
                textBoxcheck.Text = null;
            }
           
        }

        private void checkAnswer3(object sender, RoutedEventArgs e)
        {
            st+=1;
            if (st >= 1){
                MessageBox.Show("Bạn cần trọn 1 nguyện vọng hoặc 1 đáp án (Bạn có 45p để làm bài)");
            }
            DispatcherTimer dt= new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();

        }
        int increment = 0;
        
        private void dtTicker(object sender, EventArgs e) 
        {
            increment++;
            TimerLabel.Content=increment.ToString();
            if (increment == 60) {
                phut += 1;
                TimerLabel1.Content=phut.ToString();
                increment = 0;
            }
        }
    }
}
