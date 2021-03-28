/*****************************************************************************************************************************************************
**					                                            SAKARYA ÜNİVERSİTESİ                                                                **
**				                                     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                                                      **
**				                                           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                                                           **
**				                                          NESNEYE DAYALI PROGRAMLAMA DERSİ                                                          **
**					                                         2019-2020 BAHAR DÖNEMİ                                                                 **
**	                                                                                                                                                **
**				                                            ÖDEV NUMARASI..........: Proje Ödevi                                                              **
**				                                            ÖĞRENCİ ADI............: MERT SIĞIRCI                                                   **
**				                                            ÖĞRENCİ NUMARASI.......: B191210078                                                     **
**                                                          DERSİN ALINDIĞI GRUP...: 1/A                                                            **
*****************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Atık_Oyunu
{
    abstract class Atik : IAtik
    {
        public abstract int AtikHacmi { get;}
        
        public abstract int Hacim
        {
            get;   
        }

        public Image Image => throw new NotImplementedException();
    }

    class OrganikAtikKutusu : IAtikKutusu, IDolabilen
    {
        public int _organikAtikKutusuHacim = 700;
        public int _organikAtikKutusuDoluHacim = 0;
        
        public int BosaltmaPuani
        {
            get { return 0; }
        }

        public int Kapasite 
        { 
            get { return _organikAtikKutusuHacim; }
            set { _organikAtikKutusuHacim = value; } 
        }

        public int DoluHacim
        {
            get { return _organikAtikKutusuDoluHacim; }
            set { _organikAtikKutusuDoluHacim = value; }
        }

        public int DolulukOrani
        {
            get { return (DoluHacim*100 / Kapasite); }
        }


        public bool Bosalt()
        {
            if (DolulukOrani>=75)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        public bool Ekle(Atik atik)
        {
            if (atik.Hacim+DoluHacim<=Kapasite)
            {
                _organikAtikKutusuDoluHacim += atik.Hacim;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class CamAtikKutusu : IAtikKutusu, IDolabilen
    {
        public int _camAtikKutusuHacim = 2200;
        public int _camAtikKutusuDoluHacim = 0;

        public int BosaltmaPuani
        {
            get { return 600; }
        }

        public int Kapasite 
        {
            get { return _camAtikKutusuHacim; }
            set { _camAtikKutusuHacim= value; }
        }
        public int DoluHacim
        { 
            get { return _camAtikKutusuDoluHacim; }
            set { _camAtikKutusuDoluHacim = value; }          
        }

        public int DolulukOrani
        {
            get { return (DoluHacim*100 / Kapasite); }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ekle(Atik atik)
        {
            if (atik.AtikHacmi <= (Kapasite - DoluHacim))
            {
                _camAtikKutusuDoluHacim += atik.Hacim;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class MetalAtikKutusu : IAtikKutusu, IDolabilen
    {
        public int _metalAtikKutusuHacim = 2300;
        public int _metalAtikKutusuDoluHacim = 0;

        public int BosaltmaPuani
        {
            get { return 800; }
        }

        public int Kapasite
        {
            get { return _metalAtikKutusuHacim; }
            set { _metalAtikKutusuHacim = value; }
        }
        public int DoluHacim
        {
            get { return _metalAtikKutusuDoluHacim; }
            set { _metalAtikKutusuDoluHacim = value; }
        }

        public int DolulukOrani
        {
            get { return (DoluHacim*100 / Kapasite); }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ekle(Atik atik)
        {
            if (atik.AtikHacmi <= (Kapasite - DoluHacim))
            {
                _metalAtikKutusuDoluHacim += atik.Hacim;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class KagitAtikKutusu : IAtikKutusu, IDolabilen
    {
        public int _kagitAtikKutusuHacim = 1200;
        public int _kagitAtikKutusuDoluHacim = 0;

        public int BosaltmaPuani
        {
            get { return 1000; }
        }

        public int Kapasite
        {
            get { return _kagitAtikKutusuHacim; }
            set { _kagitAtikKutusuHacim = value; }
        }
        public int DoluHacim
        {
            get { return _kagitAtikKutusuDoluHacim; }
            set { _kagitAtikKutusuDoluHacim = value; }
        }

        public int DolulukOrani
        {
            get { return (DoluHacim*100 / Kapasite); }
        }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ekle(Atik atik)
        {
            if (atik.AtikHacmi <= (Kapasite - DoluHacim))
            {
                _kagitAtikKutusuDoluHacim += atik.Hacim;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Dergi : Atik
    {
        public override int AtikHacmi
        { 
            get { return 200; } 
        }

        public override int Hacim
        {
            get => AtikHacmi;
        }
    }

    class Gazete : Atik
    {
        public override int AtikHacmi
        {
            get { return 250; }
        }

        public override int Hacim
        {
            get => AtikHacmi;
        }
    }

    class KolaKutusu : Atik
    {
        public override int AtikHacmi
        {
            get { return 350; }
        }

        public override int Hacim
        {
            get => AtikHacmi;
        }
    }

    class SalcaKutusu : Atik
    {
        public override int AtikHacmi
        {
            get { return 550; }
        }

        public override int Hacim
        {
            get => AtikHacmi;
        }
    }

    class CamBardak : Atik
    {
        public override int AtikHacmi
        {
            get { return 250; }
        }

        public override int Hacim
        {
            get => AtikHacmi;
        }
    }

    class CamSise : Atik
    {
        public override int AtikHacmi
        {
            get { return 600; }
        }

        public override int Hacim
        {
            get => AtikHacmi;
        }
    }

    class Domates : Atik
    {
        public override int AtikHacmi
        {
            get { return 150; }
        }

        public override int Hacim
        {
            get => AtikHacmi;
        }
    }

    class Salatalik : Atik
    {
        public override int AtikHacmi
        {
            get { return 120; }
        }

        public override int Hacim
        {
            get => AtikHacmi;
        }

    }


    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }

    interface IAtikKutusu 
    {
        int BosaltmaPuani { get; }

        bool Ekle(Atik atik);

        bool Bosalt();
    }

    interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }

}
