using GOTECH.Crypto;
using GOTECH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOTECH.Help
{
    public partial class UserSetting : Form
    {
        private DbEntities db = new DbEntities();
        public UserSetting()
        {
            InitializeComponent();
            txtOldUser.Focus();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
           if(ValidateText(txtOldUser.Text))
           {
               if(ValidateOldUser(txtOldUser.Text))
               {
                   if(ValidateText(txtNewUser.Text))
                   {
                       UpdateUser(Gulipso.DataEncrypt(txtNewUser.Text));
                   }
                   else
                   {
                       MessageBox.Show("Please Enter New Username!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
               }
               else
               {
                   MessageBox.Show("Old Username is not correct!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
           }
            else
           {
               MessageBox.Show("Please Enter your Old Username!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
        }

        
        private void btnPassSave_Click(object sender, EventArgs e)
        {
            if(ValidateText(txtOldPass.Text))
            {
                if(ValidateOldPass(txtOldPass.Text))
                {
                    if(ValidateText(txtNewPass.Text))
                    {
                        if(ValidateText(txtConfirmPass.Text))
                        {
                            if(ComparePass(txtNewPass.Text,txtConfirmPass.Text))
                            {
                                UpdatePass(Gulipso.DataEncrypt(txtConfirmPass.Text));
                            }
                            else
                            {
                                MessageBox.Show("Confirm Password is not correct!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter your Confirm Password!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter your New Password!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Old Password is not correct!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
           {
               MessageBox.Show("Please Enter your Old Password!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
        }

        private bool ValidateText(string text)
        {
            if (text != "" && text != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateOldUser(string username)
        {
            foreach (var item in Lists.UsersList)
            {
                if (Gulipso.DataDecrypt(item.UserId) == username)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidateOldPass(string pass)
        {
            foreach (var item in Lists.UsersList)
            {
                if (Gulipso.DataDecrypt(item.Password) == pass)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ComparePass(string pass1,string pass2)
        {
            if(pass1==pass2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdateUser(string newUser)
        {
            try
            {
                var user = db.Users.Where(c => c.ID == 1).FirstOrDefault();
                user.UserId = newUser;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Your Username has been succesfully changed!", "Success - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Lists.UsersList = db.Users.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message.ToString() + "!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePass(string pass)
        {
            try
            {
                var user = db.Users.Where(c => c.ID == 1).FirstOrDefault();
                user.Password = pass;
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Your Password has been succesfully changed!", "Success - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Lists.UsersList = db.Users.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message.ToString() + "!", "Alert - GO TECH Terminal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserSetting_Activated(object sender, EventArgs e)
        {
            txtOldUser.Focus();
        }

    }
}
