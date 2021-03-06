using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140010
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //secara default
                //throw new exception(ex.message) => pesan eror secara default
                //throw new faultexcetion("Pesan Salah") => utk meloloskan pesan eror yang dikirim ke client
                MathFaultt mf = new MathFaultt();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan Input yang benar";
                throw new FaultException<MathFaultt>(mf);
            }
        }
        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFaultt mf = new MathFaultt();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan Input yang benar";
                throw new FaultException<MathFaultt>(mf);
            }
        }
        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFaultt mf = new MathFaultt();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan Input yang benar";
                throw new FaultException<MathFaultt>(mf);
            }
        }
        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFaultt mf = new MathFaultt();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan Input yang benar";
                throw new FaultException<MathFaultt>(mf);
            }
        }
        //TKoordinat:nama methodnya, a,b = input seperti int.
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MathFaultt mf = new MathFaultt();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan Input yang benar";
                throw new FaultException<MathFaultt>(mf);
            }
        }
    }
}
