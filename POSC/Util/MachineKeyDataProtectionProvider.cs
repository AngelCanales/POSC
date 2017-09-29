using Microsoft.Owin.Security.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POSC.Util
{
    public class MachineKeyDataProtectionProvider : IDataProtectionProvider
    {
        public MachineKeyDataProtectionProvider()
        {
        }

        public IDataProtector Create(params string[] purposes)
        {
            return new MachineKeyDataProtector(purposes);
        }
    }

    public class MachineKeyDataProtector : IDataProtector
    {
        private string[] purposes;

        public MachineKeyDataProtector(string[] purposes)
        {
            this.purposes = purposes;
        }

        public byte[] Protect(byte[] userData)
        {
            throw new NotImplementedException();
        }

        public byte[] Unprotect(byte[] protectedData)
        {
            throw new NotImplementedException();
        }

        //public byte[] Protect(byte[] userData)
        //{
        //    //   return MachineKey.Protect(userData, this.purposes);
        //    throw NotImplementedException x;
        //}

        //public byte[] Unprotect(byte[] protectedData)
        //{
        //    return MachineKey.Unprotect(protectedData, this.purposes);
        //}
    }
}
