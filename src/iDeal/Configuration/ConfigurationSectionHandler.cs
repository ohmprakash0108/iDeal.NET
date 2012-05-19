﻿using System;
using System.Configuration;

namespace iDeal.Configuration
{
    public class ConfigurationSectionHandler : ConfigurationSection, IConfigurationSectionHandler
    {
        public string MerchantId
        {
            get { return Merchant.Id; }
        }

        public int MerchantSubId
        {
            get { return Merchant.SubId; }
        }

        public string AcquirerUrl
        {
            get { return Aquirer.Url; }
        }

        public string CertificateName
        {
            get { return Certificate.Name; }
        }

        public string CertificateStoreName
        {
            get { return Certificate.StoreName; }
        }

        public string CertificateFilename
        {
            get { return Certificate.Filename; }
        }

        public string CertificatePassword
        {
            get { return Certificate.Password; }
        }

        public string BankCertificateName
        {
            get { return BankCertificate.Name; }
        }

        public string BankCertificateStoreName
        {
            get { return BankCertificate.StoreName; }
        }

        public string BankCertificateFilename
        {
            get { return BankCertificate.Filename; }
        }

        
        [ConfigurationProperty("merchant")]
        public MerchantElement Merchant
        {
            get
            {
                return (MerchantElement)this["merchant"];
            }
        }

        [ConfigurationProperty("acquirer")]
        public AcquirerElement Aquirer
        {
            get
            {
                return (AcquirerElement)this["acquirer"];
            }
        }

        [ConfigurationProperty("certificate")]
        public CertificateElement Certificate
        {
            get
            {
                return (CertificateElement)this["certificate"];
            }
        }

        [ConfigurationProperty("bankCertificate")]
        public BankCertificateElement BankCertificate
        {
            get
            {
                return (BankCertificateElement)this["bankCertificate"];
            }
        }
    }

    public class MerchantElement : ConfigurationElement
    {
        [ConfigurationProperty("id", IsRequired = true)]
        public String Id
        {
            get
            {
                return (String)this["id"];
            }
        }

        [ConfigurationProperty("subId", IsRequired = false)]
        public int SubId
        {
            get { return (int) this["subId"]; }
        }
    }

    public class AcquirerElement : ConfigurationElement
    {
        [ConfigurationProperty("url", IsRequired = true)]
        public String Url
        {
            get
            {
                return (String)this["url"];
            }
        }
    }

    public class CertificateElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = false)]
        public String Name
        {
            get
            {
                return (String)this["name"];
            }
        }

        [ConfigurationProperty("storeName", IsRequired = false)]
        public String StoreName
        {
            get
            {
                return (String)this["storeName"];
            }
        }

        [ConfigurationProperty("filename", IsRequired = false)]
        public String Filename
        {
            get
            {
                return (String)this["filename"];
            }
        }

        [ConfigurationProperty("password", IsRequired = false)]
        public String Password
        {
            get
            {
                return (String)this["password"];
            }
        }
    }

    public class BankCertificateElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = false)]
        public String Name
        {
            get
            {
                return (String)this["name"];
            }
        }

        [ConfigurationProperty("storeName", IsRequired = false)]
        public String StoreName
        {
            get
            {
                return (String)this["storeName"];
            }
        }

        [ConfigurationProperty("filename", IsRequired = false)]
        public String Filename
        {
            get
            {
                return (String)this["filename"];
            }
        }
    }
}