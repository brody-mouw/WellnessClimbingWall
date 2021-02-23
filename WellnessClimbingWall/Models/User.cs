using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;


namespace WellnessClimbingWall.Models
{
    public abstract class UserParent //for User and Patron classes
    {
        public string Name { get; set; }
        public int ID { get; set; } //ID used to identify them in database
        


    }

    public class User : UserParent //staff, routeSetter, or admin
    {
        public enum AccessType {none, staff, routeSetter, admin};

        //public string Name { get; set; }
        //public int ID { get; set; }

        public string Username { get; set; } //name used to log in to account
        public string PW { get; set; } //account password (hashed before it's stored)
        public bool IsHashed { get; set; } //indicate whether a password is hashed or not


        public AccessType AccessLevel { get; set; }


        public void hashPW()
        {
            if(!IsHashed)
            {
                using (var sha = new System.Security.Cryptography.SHA256Managed())
                {
                    byte[] textData = System.Text.Encoding.UTF8.GetBytes(PW);
                    byte[] hash = sha.ComputeHash(textData);
                    PW = BitConverter.ToString(hash).Replace("-", String.Empty);
                }
                IsHashed = true;
            }
        }

        //pass in entered PW as parameter; hashes it and compared to stored PW
        public bool comparePW(string enteredPW)//returns true if match; false if not
        {
            bool ret;
            if(IsHashed==false)
            {
                hashPW();
            }

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(enteredPW);
                byte[] hash = sha.ComputeHash(textData);
                enteredPW = BitConverter.ToString(hash).Replace("-", String.Empty);
            }

            if(enteredPW == PW)
            {
                ret = true;
            }
            else
            {
                ret = false;
            }


            return ret;
        }
    }
    /*
    public class Patron : UserParent
    {
        //public string Name { get; set; }
        //public int ID { get; set; }
        public enum CertType { none, topRope, lead };
        public CertType Certification { get; set; }


    }*/

}
