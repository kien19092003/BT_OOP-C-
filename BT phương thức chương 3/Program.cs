// bai1
/*class Sach
{
    public string Tensach;
    public string Tacgia;
    public int NamXB;
    public int Soluong;

    public void Nhap()
    {
        Console.Write("Nhap ten sach: ");
        Tensach = Convert.ToString(Console.ReadLine());
        Console.Write("tac gia: ");
        Tacgia = Convert.ToString(Console.ReadLine());
        Console.Write("Nam san xuat: ");
        NamXB = int.Parse(Console.ReadLine());
        Console.Write("So luong: ");
        Soluong = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine(" Sach {0}, co tac gia {1}, duoc san xuat nam {2} voi so luong {3}",Tensach,Tacgia,NamXB,Soluong);
    }
    static void Main()
    {
        Sach sach1 = new Sach();
        Sach sach2 = new Sach();
        sach1.Nhap();
        sach1.Xuat();
        sach2.Nhap();
        sach2.Xuat();
    }
}*/
// bai 3
/*class Organization
{
    public string Name,Country,City,Address,Telephone;
    public void Nhap()
    {
        Console.Write("Nhap ten doanh nghiep: ");
        Name = Convert.ToString(Console.ReadLine());
        Console.Write("quoc gia: ");
        Country = Convert.ToString(Console.ReadLine());
        Console.Write("thanh pho: ");
        City = Convert.ToString(Console.ReadLine());
        Console.Write("dia chi: ");
        Address = Convert.ToString(Console.ReadLine());
        Console.Write("so dien thoai: ");
        Telephone = Convert.ToString(Console.ReadLine());
    }
    public void Xuat()
    {
        if (Telephone.Length!=10 | Name=="" | Country=="" | City=="" | Address=="" | Telephone=="") 
            Console.WriteLine("Nhap thong tin loi !!");
        else
            Console.WriteLine(" Doang nghiep {0}, thuoc dia chi {1}, thanh pho {2}, {3}, so dien thoai lien he: {4} ",Name,Address,City,Country,Telephone);
    }
        static void Main()
    {
        Organization Organization = new Organization();   
        Organization.Nhap();
        Organization.Xuat();       
    }
}*/

// bai 4

/*class Triangle
{
    public int a,b,c,x;
    public double s,p,C;
    public void Nhap()
    {
        Console.Write("a = ");
        a=int.Parse(Console.ReadLine());
        Console.Write("b = ");
        b=int.Parse(Console.ReadLine());
        Console.Write("c = ");
        c=int.Parse(Console.ReadLine());
    }
    public void Tinh()
    {
        p = (a+b+c)/2;
        C=2*p;
        s=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        Console.WriteLine("Dang thuc hien phep tinh");
    }
    public void Xuat()
    {
        if (a+b<c | a+c<b | b+c <a)
            Console.WriteLine("Khong hop le !!");
        else
        {
            Console.WriteLine("Tam giac co do dai {0}, {1}, {2}",a,b,c);
            Console.WriteLine("Chu vi cua tam giac la: {0}",C);
            Console.WriteLine("Dien tich cua tam giac la: {0}",s);  
        }          
    }
    static void Main()
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Menu:\nBam 1: Nhap cac canh a,b,c cua tam giac \nBam 2: Tinh chu vi va dien tich hinh tam giac \nBam 3: Xuat ra cac gia tra a,b,c");
            Console.Write("Moi chon so: ");
            int x = int.Parse(Console.ReadLine());
            do
            {
                if (x==1)
                    triangle.Nhap();
                else if (x==2)
                    triangle.Tinh();
                else if (x==3)
                    triangle.Xuat();
                Console.WriteLine("Moi chon so: ");
                x = int.Parse(Console.ReadLine());
            }   while (x!=0);            
        }
}*/


// bai 2
/*class meo
{
    public string Ten,Giong,Gioitinh;
    public int Tuoi,dem;
    public void Nhap()
    {
        Console.Write("Nhap ten meo: ");
        Ten = Console.ReadLine();
        Console.Write("Giong meo: ");
        Giong = Console.ReadLine();
        Console.Write("Gioi tinh: ");
        Gioitinh = Console.ReadLine();
        Console.Write("Tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Meo {0} thuoc giong {1}, gioi tinh {2}, nam nay duoc {3} tuoi ",Ten,Giong,Gioitinh,Tuoi);
    }
    static void Main()
    {
        Console.Write("Moi ban nhap thong tin be meo so: ");
        int n = int.Parse(Console.ReadLine());
        int dem=0;
        do
        {
            meo m = new meo();
            m.Nhap();
            m.Xuat();
            dem=dem+1;
            Console.Write("Moi ban nhap thong tin be meo so: ");
            n = int.Parse(Console.ReadLine());      
        }while (n!=0);
        Console.WriteLine("Danh sach co tong cong {0} be meo",dem);
    }
}*/

// bai 3
/*class Organization
{
    public string Name,Country,City,Address,Telephone;
    public int n;
    public void Nhap()
    {
        n=5;
        for (;true;)
        {
        Console.Write("Nhap ten doanh nghiep: ");
        Name = Convert.ToString(Console.ReadLine());
        if (Name=="")
        {
            n--;
            Console.WriteLine("Nhap thong tin loi !!");
            break;
        }
        
        Console.Write("quoc gia: ");
        Country = Convert.ToString(Console.ReadLine());
        if (Country=="")
        {
            n--;
            Console.WriteLine("Nhap thong tin loi !!");
            break;
        }
        Console.Write("thanh pho: ");
        City = Convert.ToString(Console.ReadLine());
        if (City=="")
        {
            n--;
            Console.WriteLine("Nhap thong tin loi !!");
            break;
        }
        Console.Write("dia chi: ");
        Address = Convert.ToString(Console.ReadLine());
        if (Address=="")
        {
            n--;
            Console.WriteLine("Nhap thong tin loi !!");
            break;
        }
        Console.Write("so dien thoai: ");
        Telephone = Convert.ToString(Console.ReadLine());
        if (Telephone!="")
        {
            foreach (int so in Telephone)
            {
                if (so!=1 & so!=2 & so!=3 & so!=4 & so!=5 & so!=6 & so!=7 & so!=8 & so!=9 & so!=0 | Telephone.Length!=10)
                {
                    n--;
                    Console.WriteLine("Nhap thong tin loi !!");  
                    break;              
                }
            }
            break;
        }

        if (n==5)
            break;
        }
    }
    public void Xuat()
    {
        if (n==5) 
            Console.WriteLine(" Doang nghiep {0}, thuoc dia chi {1}, thanh pho {2}, {3}, so dien thoai lien he: {4} ",Name,Address,City,Country,Telephone);
    }
        static void Main()
    {
        Organization Organization = new Organization();   
        Organization.Nhap();
        Organization.Xuat();       
    }
}*/