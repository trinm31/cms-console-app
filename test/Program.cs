using System;
using System.Collections;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const Int32 Max =100;
            Int32[] id = new Int32[Max];
            String[] name = new string[Max];
            Int32[] score = new Int32[Max];
            Console.WriteLine("----------Quan ly sinh vien-----------\n\n\n\n");
        begin:
            Console.WriteLine("1.Hien thi sv");
            Console.WriteLine("2.Them moi sinh vien");
            Console.WriteLine("3.Sua sinh vien");
            Console.WriteLine("4.xoa sinh vien");
            Console.WriteLine("5.Thoat");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Moi chon tuy chon");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Cac sinh vien la:");
                    for (int i =0; i < Max; i++ )
                    {
                        Console.WriteLine("Ma so sinh vien: {0}, Ten sinh vien: {1}, Diem sinh vien: {2}",id[i],name[i],score[i]);
                    }
                    Console.ReadKey();
                    goto case 5;
                case 2:
                    Console.WriteLine("Ban muon nhap bao nhieu sinh vien");
                    int svn = Convert.ToInt32(Console.ReadLine());
                    for (int i =0; i <svn; i++)
                    {
                        Console.WriteLine("Nhap vao id sinh vien thu {0}",i);
                        id[i] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap vao ten sinh vien thu {0}", i);
                        name[i] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Nhap vao diem sinh vien thu {0}", i);
                        score[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Cac sinh vien la:");
                    for (int i = 0; i < svn; i++)
                    {
                        Console.WriteLine("Ma so sinh vien: {0}, Ten sinh vien: {1}, Diem sinh vien: {2}", id[i], name[i], score[i]);
                    }
                    Console.ReadKey();
                    goto case 5;
                case 3:
                    Console.WriteLine("Nhap vao id sinh vien can sua");
                    int Id = Convert.ToInt32(Console.ReadLine());
                    for (int i =0; i< Max; i++)
                    {
                        if (id[i] == Id)
                        {
                            Console.WriteLine("nhap vao ten can sua");
                            name[i] = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("nhap vao diem can sua");
                            score[i] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Id = 0;
                    goto case 5;
                case 4:
                    Console.WriteLine("Nhap vao id sinh vien can xoa");
                    Id = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < Max; i++)
                    {
                        if (id[i] == Id)
                        {
                            for (int j = i; j<Max -1; j++)
                            {
                                id[j] = id[j + 1];
                                name[j] = name[j + 1];
                                score[j] = score[j + 1];
                            }
                        }
                    }
                    goto case 5;
                case 5:

                    Console.WriteLine("Ban co muon tiep tuc ko: y de tiep tuc/ n de ket thuc ");
                    char y = Convert.ToChar(Console.ReadLine());
                    if (y == 'y')
                    {
                        goto begin;
                    }
                    break;
            }
            Console.WriteLine("...........................................");
        }
    }
}
