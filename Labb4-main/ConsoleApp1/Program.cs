using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleListProgram
{
    class Program
    {
        static bool IsAuthenticated = false; // ����� ��� �������� �����������

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> numbers = new List<int>(); // ��������� ������ ����� �����

            Authenticate(); // ������ ������� �����������

            if (IsAuthenticated)
            {
                bool exit = false;
                while (!exit)
                {
                    // ������� ��� ���������� ��������
                    // ...
                }

                Console.WriteLine("�������� ��������� ������.");
            }
            else
            {
                Console.WriteLine("����������� �� ������� ������. �������� ��������� ������.");
            }
        }

        static void Authenticate()
        {
            // ������� ������� ����������� (� �������)
            Console.WriteLine("������ ������:");
            string password = Console.ReadLine();

            // �������� ������ (���� ���� ���� �������� ������� �� ������)
            if (password == "password123")
            {
                IsAuthenticated = true;
                Console.WriteLine("����������� ������!");
            }
            else
            {
                Console.WriteLine("������������ ������. ����������� �� �������.");
            }
        }
    }
}