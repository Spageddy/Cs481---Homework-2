using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Homework_2
{
    public partial class MainPage : ContentPage
    {
        int first_num = 0;
        int second_num = 0;
        char op;

        public MainPage()
        {
            InitializeComponent();


            
        }
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;//for button


            //animate
            await button.ScaleTo(2, 50);
            await button.ScaleTo(1, 100, Easing.BounceIn);

            //show results
            if (result.Text == "0")
            {
                result.Text = button.Text;
            }
            else
            {
                result.Text = result.Text + button.Text;
            }
        }

        async void Clear_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;//for button

            //animate
            await button.ScaleTo(2, 50);
            await button.ScaleTo(1, 100, Easing.BounceIn);

            //set back to 0
            result.Text = "0";
            first_num = 0;
            second_num = 0;
            op = ' ';
        }

        async void op_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;//for button

            //animate
            await button.ScaleTo(2, 50);
            await button.ScaleTo(1, 100, Easing.BounceIn);

            first_num = Convert.ToInt32(result.Text);
            op = Convert.ToChar(button.Text);
            result.Text = "0";

        }

        async void Equal_Clicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;//for button

            //animate
            await button.ScaleTo(2, 50);
            await button.ScaleTo(1, 100, Easing.BounceIn);

            second_num = Convert.ToInt32(result.Text);

            switch (op)
            {
                case '+':
                    result.Text = Convert.ToString(first_num + second_num);
                    first_num = Convert.ToInt32(result.Text);
                    second_num = 0;
                    break;
                case '-':
                    result.Text = Convert.ToString(first_num - second_num);
                    first_num = Convert.ToInt32(result.Text);
                    second_num = 0;
                    break;
                case '/':
                    result.Text = Convert.ToString(first_num / second_num);
                    first_num = Convert.ToInt32(result.Text);
                    second_num = 0;
                    break;
                case 'x':
                    result.Text = Convert.ToString(first_num * second_num);
                    first_num = Convert.ToInt32(result.Text);
                    second_num = 0;
                    break;

            }

        }
    }
}
