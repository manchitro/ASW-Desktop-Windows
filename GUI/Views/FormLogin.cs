﻿using DataLayer.Models;
using DataLayer.Models.BaseModels;
using GUI.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = textBoxEmail;

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxEmail.Focus();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (!(textBoxEmail.Text == "Email") && !(textBoxPassword.Text == "Password"))
            {
                var controller = new UserController();
                FacultyUserModel faculty = controller.ValidateLogin(textBoxEmail.Text, textBoxPassword.Text);
                if(faculty == null)
                {
                    textBoxPassword.Clear();
                    textBoxPassword.Focus();
                }
                else
                {
                    //MessageBox.Show("Login successful.\nID: " + faculty.Id + "\nName: " + faculty.FullName + "\nEmail: " + faculty.Email);
                    var dash = new FormDashboard(faculty);
                    dash.FormClosed += new FormClosedEventHandler(dash_FormClosed);
                    dash.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Please insert your login credentials first");
            
        }

        private void dash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (panelSignUp.Location.X.CompareTo(0) > 0)
                panelSignUp.Location = new Point(panelSignUp.Location.X - 14, panelSignUp.Location.Y);
            else
                timerLoginPanelSlider.Stop();
        }

        private void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            timerLoginPanelSlider.Interval = 1;
            timerLoginPanelSlider.Start();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            timerLoginPanelSliderReverse.Interval = 1;
            timerLoginPanelSliderReverse.Start();
        }

        private void TimerLoginPanelSliderReverse_Tick(object sender, EventArgs e)
        {
            if (panelSignUp.Location.X.CompareTo(350) < 0)
                panelSignUp.Location = new Point(panelSignUp.Location.X + 14, panelSignUp.Location.Y);
            else
                timerLoginPanelSliderReverse.Stop();
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPassword.Text) || textBoxPassword.Text == "Password")
            {
                textBoxPassword.Clear();
                textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
                textBoxPassword.UseSystemPasswordChar = true;
            }
            panelPasswordUnderline.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void TextBoxEmail_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
            panelEmailUnderline.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void TextBoxIdSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxAcademicIdSignUp.Text == "Academic ID")
            {
                textBoxAcademicIdSignUp.Clear();
                textBoxAcademicIdSignUp.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
            panelIdSignUpUnderline.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void TextBoxFirstNameSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNameSignUp.Text == "First Name")
            {
                textBoxFirstNameSignUp.Clear();
                textBoxFirstNameSignUp.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
            panelFirstNameSignUpUnderline.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void TextBoxEmailSignup_Click(object sender, EventArgs e)
        {
            if (textBoxEmailSignup.Text == "Academic Email")
            {
                textBoxEmailSignup.Clear();
                textBoxEmailSignup.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
            }
            panelEmailSignUpUnderline.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void TextBoxPassSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxPassSignUp.Text == "Password")
            {
                textBoxPassSignUp.Clear();
                textBoxPassSignUp.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
                textBoxPassSignUp.UseSystemPasswordChar = true;
            }
            panelPassSignUpUnderline.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void TextBoxConfirmPassSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxConfirmPassSignUp.Text == "Confirm Password")
            {
                textBoxConfirmPassSignUp.Clear();
                textBoxConfirmPassSignUp.ForeColor = System.Drawing.Color.FromArgb(217, 217, 217);
                textBoxConfirmPassSignUp.UseSystemPasswordChar = true;
            }
            panelConfirmPassSignUpUnderline.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxEmail.Text = "Email";
            }
            panelEmailUnderline.BackColor = Color.FromArgb(112, 112, 112);
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "Password";
            }
            panelPasswordUnderline.BackColor = Color.FromArgb(112, 112, 112);
        }

        private void TextBoxIdSignUp_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxAcademicIdSignUp.Text))
            {
                textBoxAcademicIdSignUp.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxAcademicIdSignUp.Text = "Academic ID";
            }
            panelIdSignUpUnderline.BackColor = Color.FromArgb(112, 112, 112);
        }

        private void TextBoxFirstNameSignUp_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxFirstNameSignUp.Text))
            {
                textBoxFirstNameSignUp.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxFirstNameSignUp.Text = "First Name";
            }
            panelFirstNameSignUpUnderline.BackColor = Color.FromArgb(112, 112, 112);
        }

        private void TextBoxEmailSignup_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxEmailSignup.Text))
            {
                textBoxEmailSignup.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxEmailSignup.Text = "Academic Email";
            }
            panelEmailSignUpUnderline.BackColor = Color.FromArgb(112, 112, 112);
        }

        private void TextBoxPassSignUp_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPassSignUp.Text))
            {
                textBoxPassSignUp.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxPassSignUp.UseSystemPasswordChar = false;
                textBoxPassSignUp.Text = "Password";
            }
            panelPassSignUpUnderline.BackColor = Color.FromArgb(112, 112, 112);
        }

        private void TextBoxConfirmPassSignUp_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxConfirmPassSignUp.Text))
            {
                textBoxConfirmPassSignUp.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxConfirmPassSignUp.UseSystemPasswordChar = false;
                textBoxConfirmPassSignUp.Text = "Confirm Password";
            }
            panelConfirmPassSignUpUnderline.BackColor = Color.FromArgb(112, 112, 112);
        }

        private void ButtonForgotPassword_Click(object sender, EventArgs e)
        {
            timerResetPasswordSlider.Start();
        }

        private void TimerResetPasswordSlider_Tick(object sender, EventArgs e)
        {
            if (panelResetPassword.Location.X.CompareTo(0) < 0)
                panelResetPassword.Location = new Point(panelResetPassword.Location.X + 14, panelResetPassword.Location.Y);
            else
                timerResetPasswordSlider.Stop();
        }

        private void ButtonCancelReset_Click(object sender, EventArgs e)
        {
            timerResetPasswordSliderReverse.Start();
        }

        private void TimerResetPasswordSliderReverse_Tick(object sender, EventArgs e)
        {
            if (panelResetPassword.Location.X.CompareTo(-350) > 0)
                panelResetPassword.Location = new Point(panelResetPassword.Location.X - 14, panelResetPassword.Location.Y);
            else
                timerResetPasswordSliderReverse.Stop();
        }

        private void ButtonCancel_Click_1(object sender, EventArgs e)
        {
            timerLoginPanelSliderReverse.Interval = 1;
            timerLoginPanelSliderReverse.Start();
        }

        private void ButtonLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TextBoxEmailReset_Click(object sender, EventArgs e)
        {
            if (textBoxEmailReset.Text == "Enter email to continue")
            {
                textBoxEmailReset.Clear();
                textBoxEmailReset.ForeColor = Color.FromArgb(217, 217, 217);
            }
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            if (!(textBoxFirstNameSignUp.Text == "First Name") && !(textBoxLastNameSignUp.Text == "Last Name"))
            {
                if (textBoxPassSignUp.Text == textBoxConfirmPassSignUp.Text)
                {
                    //MessageBox.Show("Sign up pressed");
                    FacultyUserModel faculty = new FacultyUserModel();
                    faculty.AcademicId = textBoxAcademicIdSignUp.Text;
                    faculty.FirstName = textBoxFirstNameSignUp.Text;
                    faculty.LastName = textBoxLastNameSignUp.Text;
                    faculty.Email = textBoxEmailSignup.Text;
                    faculty.Password = textBoxPassSignUp.Text;
                    //faculty.CreatedAt = 
                    //faculty.CreatedAt = DateTime.Now;

                    try
                    {
                        faculty.IsValid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Data accepted");

                    try
                    {
                        var controller = new UserController();
                        controller.Create(faculty);
                        buttonCancel.PerformClick();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Please fill up all fields");
            }
            
        }

        private void ButtonResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A 5 digit code has been sent to your email. Press OK and enter the code");
        }

        private void TextBoxIdSignUp_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBoxFirstNameSignUp_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void TextBoxFirstNameSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                textBoxLastNameSignUp.Focus();
            }
        }

        private void TextBoxLastNameSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxLastNameSignUp.Text == "Last Name")
            {
                textBoxLastNameSignUp.Clear();
                textBoxLastNameSignUp.ForeColor = Color.FromArgb(217, 217, 217);
            }
            panelLastNameSignUpUnderline.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void TextBoxLastNameSignUp_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLastNameSignUp.Text))
            {
                textBoxLastNameSignUp.ForeColor = Color.FromArgb(112, 112, 112);
                textBoxLastNameSignUp.Text = "Last Name";
            }
            panelLastNameSignUpUnderline.BackColor = Color.FromArgb(112, 112, 112);
        }

        private void PanelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
