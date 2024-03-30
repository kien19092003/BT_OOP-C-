
/*namespace Bai1
{
    class Phanso
    {
        private int tu,mau;
        public void Nhap()
        {
            Console.Write("Nhap vao tu so: ");  
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao mau so: ");
            mau = int.Parse(Console.ReadLine());
            if (mau==0){
                Console.WriteLine("Nhap sai, vui long nhap lai");
                mau = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}/{1}",tu,mau);
        }
        static int ucln(int tu, int mau)
        {
            if (tu<0)
                tu=tu*(-1);
            if (mau<0)
                mau=mau*(-1);
            while (tu!=mau)
            {
                if (tu>mau)
                    tu = tu-mau;
                else
                    mau = mau-tu;
            }
            return tu;
        }
        public void rutgon()
        {
            int x = ucln(tu, mau);
            tu = tu/x;
            mau=mau/x;
        }

        public void cong( Phanso ps2)
        {
            Phanso pstong = new Phanso();
            pstong.tu = tu*ps2.mau + ps2.tu*mau;
            pstong.mau = mau*ps2.mau;
            pstong.rutgon();
            Console.Write("Tong cua 2 phan so: ");
            pstong.Xuat();
            

        }
        public void tru(Phanso ps2)
        {
            Phanso pshieu = new Phanso();
            pshieu.tu = tu*ps2.mau - ps2.tu*mau;
            pshieu.mau = mau*ps2.mau;
            pshieu.rutgon();
            Console.Write("Hieu cua 2 phan so: ");
            pshieu.Xuat();
            
        }
        public void nhan(Phanso ps2)
        {
            Phanso pstich = new Phanso();
            pstich.tu = tu*ps2.tu;
            pstich.mau = mau*ps2.mau;
            pstich.rutgon();
            Console.Write("Tich cua 2 phan so: ");
            pstich.Xuat();
        }
        public void chia(Phanso ps2)
        {
            Phanso psthuong = new Phanso();
            psthuong.tu = tu*ps2.mau;
            psthuong.mau = mau*ps2.tu;
            psthuong.rutgon();
            Console.Write("Thuong cua 2 phan so: ");
            psthuong.Xuat();
        }
        public void Xuat()
        {
            if (tu==mau)
                Console.WriteLine(1);
            else if (tu+mau==0)
                Console.WriteLine(-1);
            else if (tu%mau==0)
                Console.WriteLine(tu/mau);
            else
                Console.WriteLine("{0}/{1}",tu,mau);
        }
        static void Main()
        {
            Phanso ps1 = new Phanso();
            Phanso ps2 = new Phanso();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("     MOI NHAP VAO PHAN SO 1      ");
            ps1.Nhap();
            ps1.rutgon();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("     MOI NHAP VAO PHAN SO 2      ");
            ps2.Nhap();
            ps2.rutgon();
            Console.WriteLine("----------------------------------");
            ps1.cong(ps2);
            ps1.tru(ps2);
            ps1.nhan(ps2);
            ps1.chia(ps2);

        }
    }
}*/

// bai 3
/*class Tamgiac
{
    private double a,b,c;
    private string loai;
    public void nhap()
    {
        Console.Write("a = ");
        a=double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b=double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c=double.Parse(Console.ReadLine());
    }
    public void kiemtra()
    {
        if (a+b>c & b+c>a & a+c>b)
        {
            if (a==b & a==c)
                loai="deu";
            else if (a==b | a==c | b==c)
                loai = "can";
            else if (a*a==b*b+c*c | b*b==a*a+c*c | c*c==a*a+b*b)
            {    
                if (a==b | b==c | a==c)
                    loai="vuong can";
                else
                    loai="vuong";
            }
            else
                loai="thuong";
        }
        else
            loai="none";
            
    }
    public void xuat()
    {
        if (loai=="deu")
            Console.WriteLine("Day la tam giac deu");
        else if (loai=="can")
            Console.WriteLine("Day la tam giac can");
        else if (loai=="vuong can")
            Console.WriteLine("Day la tam giac vuong can");
        else if (loai=="vuong")
            Console.WriteLine("Day la tam giac vuong");
        else if (loai=="none")
            Console.WriteLine("Khong hop le !!");
        else
            Console.WriteLine("Day la tam giac thuong");
    }
    static void Main()
    {
        Tamgiac tamgiac = new Tamgiac();
        tamgiac.nhap();
        tamgiac.kiemtra();
        tamgiac.xuat();
    }
}*/

// bai 5
/*class Doanhnghiep
{
    public string TenDN,Diachi;
    public int Count,MST;
    // public string Nhap()
    // {
    //     Console.Write("Nhap vao ten doanh nghiep: ");
    //     TenDN = Console.ReadLine();
    //     Console.Write("Nhap vao ma so thue: ");
    //     MST = Console.ReadLine();
    //     Console.Write("Nhap vao dia chi cua doanh nghiep: ");
    //     Diachi = Console.ReadLine();
    //     return TenDN;
    // }
    public void Nhap()
        {   
            string[] ListDN;
            ListDN = new string[Count];
            for (int i = 0; i<Count; i++)
            {
                Console.Write("Nhap ten doanh nghiep: ");
                TenDN = Console.ReadLine();
            }
            string[] ListMST;
            ListMST = new string[Count];
            for (int j = 0; j<Count; j++)
            {
                Console.Write("Nhap ma so thue: ");
                MST = int.Parse(Console.ReadLine());
            }
            string[] ListDiaChi;
            ListDiaChi = new string[Count];
            for (int k = 0; k<Count; k++)
            {
                Console.Write("Nhap dia chi doanh nghiep: ");
                Diachi = Console.ReadLine();
            }
            Count = Count + 1;
        }
    public string Xuat()
    {
        Console.WriteLine("Doanh nghiep {0} co ma so thue la {1} thuoc dia chi {2}",TenDN,MST,Diachi);
        return TenDN;
    }
}
class DanhsachDN
{
    static void Main()
    {

        // int n;
        // Console.Write("Nhap so luong doanh nghiep: ");
        // n = int.Parse(Console.ReadLine());
        // string [] ds = new string[n];
        // for (int i=1;i<=n;i++)
        // {
        //     Console.WriteLine("Moi nhap thong tin doanh nghiep thu {0}",i);
        //     Doanhnghiep dn = new Doanhnghiep();
        //     dn.Nhap();
        //     // ds.Add(dn);
        // }
        // for (int i=1;i<=n;i++)
        // {
        //     Console.WriteLine(ds[i]);
        // }
        Doanhnghiep dn = new Doanhnghiep();
        dn.Nhap();
    }
}*/

// bai 4
/*class Info
{
    public string ID,Hoten,Group;
    public void Nhap()
    {
        Console.Write("Nhap ma sinh vien: ");
        ID = Console.ReadLine();
        if (ID==""){
            Console.WriteLine("Thong tin loi !! \nVui long nhap lai.");
            Console.Write("Nhap ma sinh vien: ");
            ID = Console.ReadLine();
        }           
        Console.Write("Nhap ho va ten sinh vien: ");
        Hoten = Console.ReadLine();
        if (Hoten==""){
            Console.WriteLine("Thong tin loi !! \nVui long nhap lai.");
            Console.Write("Nhap ho va ten sinh vien: ");
            Hoten = Console.ReadLine();
        } 
        Console.Write("Nhap lop sinh hoat: ");
        Group = Console.ReadLine();
        if (Group==""){
            Console.WriteLine("Thong tin loi !! \nVui long nhap lai.");
            Console.Write("Nhap lop sinh vien: ");
            Group = Console.ReadLine();
        } 
    }
}
class DiemTP 
{
    public double TP1,TP2,TP3;
    public void nhapdiem()
    {
        Console.Write("Nhap diem thanh phan 1: ");
        TP1 = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem thanh phan 2: ");
        TP2 = double.Parse(Console.ReadLine());
        Console.Write("Nhap diem thanh phan 3: ");
        TP3 = double.Parse(Console.ReadLine());
    }
    public double tinhdtb()
    {
        double dtb = TP1*0.1 + TP2*0.3 + TP3*0.6;
        return dtb;
    }
    // public void Xuat()
    // {
    //     Console.WriteLine("Sinh vien {0} co ID {1}, lop sinh hoat {2} co diem trung binh la {3}",Hoten,ID,Group,tinhdtb());
    // }
}
class program
{
    static void Main()
    {
        Info info = new Info();
        DiemTP sv = new DiemTP();
        int dem =0;
        Console.Write("Nhap t de nhap vao thong tin cac sinh vien: ");
        string x = Console.ReadLine();
        do{
            info.Nhap();
            sv.nhapdiem();
            sv.Xuat();
            dem++;
            Console.WriteLine("------------------------------------------");
            Console.Write("Nhap t de tiep tuc viec nhap thong tin: ");
            x = Console.ReadLine();
        }while (x=="t");
        Console.WriteLine("Lop hoc phan OOP co tat ca {0} sinh vien",dem);
    }
}*/

// Bai 2

/*class sophuc
{
    public double phanthuc,phanao;
    public void nhap()
    {
        Console.Write("Nhap phan thuc: ");
        phanthuc=double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao: ");
        phanao=double.Parse(Console.ReadLine());
    }
    public void cong(sophuc sp2)
    {
        sophuc sptong = new sophuc(); 
        sptong.phanthuc = phanthuc + sp2.phanthuc;
        sptong.phanao = phanao + sp2.phanao;
        Console.Write("Tong cua 2 so phuc la: ");
        sptong.xuat();
    }
    public void tru(sophuc sp2)
    {
        sophuc sphieu = new sophuc();
        sphieu.phanthuc = phanthuc - sp2.phanthuc;
        sphieu.phanao = phanao - sp2.phanao;
        Console.Write("Hieu cua 2 so phuc la: ");
        sphieu.xuat();
    }
    public void nhan(sophuc sp2)
    {
        sophuc sptich = new sophuc();
        sptich.phanthuc = (phanthuc * sp2.phanthuc - phanao*sp2.phanao);
        sptich.phanao = (phanthuc * sp2.phanao + phanao*sp2.phanthuc);
        Console.Write("Tich cua 2 so phuc la: ");
        sptich.xuat();
    }
    public void chia(sophuc sp2)
    {
        sophuc spthuong = new sophuc();
        spthuong.phanthuc = (phanthuc*sp2.phanthuc + phanao*sp2.phanao)/(sp2.phanao*sp2.phanao + sp2.phanthuc*sp2.phanthuc);
        spthuong.phanao = (phanao*sp2.phanthuc - phanthuc*sp2.phanao)/(sp2.phanao*sp2.phanao + sp2.phanthuc*sp2.phanthuc);
        double a = phanthuc*sp2.phanthuc + phanao*sp2.phanao;
        double b = phanao*sp2.phanthuc - phanthuc*sp2.phanao;
        double c = sp2.phanao*sp2.phanao + sp2.phanthuc*sp2.phanthuc;
        if (sp2.phanthuc==0 & sp2.phanao==0)
            Console.WriteLine("Khong thuc hien duoc phep chia vi so phuc 2 bang 0");
        else if (a%c!=0){
            if (b%c!=0){
                Console.WriteLine("Thuong cua 2 so phuc la: {0}/{1} + ({2}/{3})i",a,c,b,c);
            }
            else if (b%c==0){
                Console.WriteLine("Thuong cua 2 so phuc la: {0}/{1} + {2}i",a,c,b/c);}
        else if (a%c==0 & b%c!=0)
            Console.WriteLine("Thuong cua 2 so phuc la: {0} + {1}/{2}i",a/c,b,c);
        }
        else{
            Console.Write("Thuong cua 2 so phuc la: ");
            spthuong.xuat();}
    }
    public void xuat()
    {
        if (phanthuc==0)
            if (phanao==0)
                Console.WriteLine(phanthuc);
            else
                Console.WriteLine(phanao + "i");
        else if (phanao==0)
            Console.WriteLine(phanthuc);
        else if (phanao<0)
            Console.WriteLine("{0} - {1}i",phanthuc,0-phanao);
        else
            Console.WriteLine("{0} + {1}i",phanthuc,phanao);
    }
    static void Main()
    {
        sophuc sp1 = new sophuc();
        sophuc sp2 = new sophuc();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("NHAP VAO SO PHUC 1: ");
        sp1.nhap();
        sp1.xuat();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("NHAP VAO SO PHUC 2: ");
        sp2.nhap();
        sp2.xuat();
        Console.WriteLine("---------------------------------------");
        sp1.cong(sp2);
        sp1.tru(sp2);
        sp1.nhan(sp2);
        sp1.chia(sp2);

    }
}*/

// bai 5
// class doanhnghiep
// {
//     public string TenDN, MST, Diachi;

//     public string Nhap()
//     {
//         Console.Write("Nhap vao ten doanh nghiep: ");
//         TenDN = Console.ReadLine();
//         Console.Write("Nhap vao ma so thue: ");
//         MST = Console.ReadLine();
//         Console.Write("Nhap vao dia chi cua doanh nghiep: ");
//         Diachi = Console.ReadLine();
//         return TenDN;
//     }
// }



using System;
namespace Baitap
{
    class Phanso
    {   
        private int Tu,Mau;
        public void Nhap()
        {
            Console.Write("Nhap tu so phan so: ");
            Tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so phan so: ");
            Mau = int.Parse(Console.ReadLine());
            if (Mau==0) {
                Console.WriteLine("Lỗi!!!");
                Console.Write("Nhap mau so phan so: ");
                Mau = int.Parse(Console.ReadLine());
            }
        }
        static int GCD(int a, int b) 
        {
            int r;
            while (b != 0) 
            {   
                a = Math.Abs(a);
                b = Math.Abs(b);
                r = (a % b);
                a = b;
                b = r;
            }
            return a;
        }
        public void Cong(Phanso ps2)
        {   
            Phanso cong = new Phanso();
            if (ps2.Mau == Mau && ps2.Mau !=0 && Mau != 0)
            {       
                cong.Tu = Tu + ps2.Tu;
                cong.Mau = ps2.Mau;
            }
            else
            {
                cong.Tu = Tu*ps2.Mau+ps2.Tu*Mau;
                cong.Mau = Mau*ps2.Mau;
            }

            int gcd = GCD(cong.Tu,cong.Mau);
            cong.Tu = cong.Tu/gcd;
            cong.Mau = cong.Mau/gcd;
            cong.Xuat();    
        }
        public void Tru(Phanso ps2)
        {   
            Phanso tru = new Phanso();
            if (ps2.Mau == Mau && ps2.Mau !=0 && Mau != 0)
            {       
                tru.Tu = Tu - ps2.Tu;
                tru.Mau = ps2.Mau;
            }
            else
            {
                tru.Tu = Tu*ps2.Mau-ps2.Tu*Mau;
                tru.Mau = Mau*ps2.Mau;
            }

            int gcd = GCD(tru.Tu,tru.Mau);
            tru.Tu = tru.Tu/gcd;
            tru.Mau = tru.Mau/gcd;
            tru.Xuat();
            
        }
        public void Nhan(Phanso ps2)
        {   
            Phanso nhan = new Phanso();
            nhan.Tu = Tu*ps2.Tu;
            nhan.Mau = Mau*ps2.Mau;
            int gcd = GCD(nhan.Tu,nhan.Mau);
            nhan.Tu = nhan.Tu/gcd;
            nhan.Mau = nhan.Mau/gcd;
            nhan.Xuat();
        }
        public void Chia(Phanso ps2)
        {   
            Phanso chia = new Phanso();
            chia.Tu = Tu*ps2.Mau;
            chia.Mau = Mau*ps2.Tu;
            int gcd = GCD(chia.Tu,chia.Mau);
            chia.Tu = chia.Tu/gcd;
            chia.Mau = chia.Mau/gcd;
            chia.Xuat();
        }
        public void Xuat()
        {
            if ((Mau < 0 && Tu > 0) || (Tu<0 || Mau<0))
                Console.WriteLine("-{0}/{1}", Math.Abs(Tu), Math.Abs(Mau));
            else if (Tu%Mau == 0 || Tu==Mau)
                Console.WriteLine(Tu/Mau);
            else
                Console.WriteLine("{0}/{1)",Tu,Mau);
        }
        static void Main()
        {   
            Phanso ps1 = new Phanso();
            Phanso ps2 = new Phanso();
            Console.WriteLine("PHAN SO 1:");
            ps1.Nhap();
            Console.WriteLine("PHAN SO 2:");
            ps2.Nhap();
            ps1.Cong(ps2);
            ps1.Tru(ps2);
            ps1.Nhan(ps2);
            ps1.Chia(ps2);
        }
    }
}