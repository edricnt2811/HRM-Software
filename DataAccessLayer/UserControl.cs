﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DataAccessLayer
{
    public class UserControl
    {
        public static string SHA256(string Pass)
        {
            try
            {
                SHA256Managed crypt = new SHA256Managed();
                string hash = string.Empty;
                byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(Pass), 0, Encoding.UTF8.GetByteCount(Pass));
                foreach(byte bit in crypto)
                {
                    hash += bit.ToString("x2");
                }
                return hash;
            }
            catch
            {
                return null;
            }
        }
    }
}
