namespace App 
{

    class Rumus 
    {

        public int hasil;

        public static void tampil(){
            Console.WriteLine("belajar static");
        }

        public int set(int hasil){
            return this.hasil = hasil;
        }

        public void get(){
            Console.WriteLine(this.hasil);
        }
    }

}