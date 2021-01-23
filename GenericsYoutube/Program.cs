using System;

namespace GenericsYoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            Console.WriteLine(myList.Count);       //0
            myList.Add("Ankara");
            myList.Add("İstanbul");
            myList.Add("İzmir");
            Console.WriteLine(myList.Count);       //3
        }
    }


    //GENERIC CLASS
    //Türden bağımsız işlem yaptığımız methodlar ya da classlardır.
    //Herhangi bir türe bağlı kalmadan bunları tanımlayabiliriz.
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        //new'lediğimiz an constructor çalışacak ve eleman sayısı 0 olan bir array oluşacak.
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            //Her new'lediğimizde önceki arraydeki tüm verileri kaybederiz.
            //O yüzden new'lemeden önce geçici bir arrayde eski arrayimizi tutmalıyız.

            _tempArray = _array; //_tempArray, _array'in referansını tutuyor. Kopyaladık gibi.

            _array = new T[_array.Length + 1]; //_array'in boyutunu 1 arttırdık.

            //_tempArray'deki verileri sırasıyla _array'e aktarıyoruz.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;  //Boyutu 1 arttığından eklenen  elemanı kendimiz ekliyoruz.
        }


        //Array'in eleman sayısını döndürecek.
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
