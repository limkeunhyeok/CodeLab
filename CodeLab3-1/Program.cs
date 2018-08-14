using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyIntegerArray array = new MyIntegerArray();
            array.InsertionSort();
            array.PrintArray();

            array.SizeUp();
            array.PrintArray();

            array.SetAt(3, 1000);
            array.PrintArray();

            int[] result = array.SliceArray(3, 7);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }

    internal class MyIntegerArray
    {
        private int[] datas;

        public MyIntegerArray()
        {
            datas = new int[10];
            SetArrayRandomly();
            // 기본 생성자는 디폴트로 크기가 10인 배열 생성
        }

        public MyIntegerArray(int size)
        {
            datas = new int[size];
            SetArrayRandomly();
            // 생성자를 오버로딩하여 입력받은 파라미터 사이즈에 따라 배열 생성
        }

        // 정렬, 탐색 등의 메서드 구현
        public int At(int index)                        // arr[index]
        {
            return datas[index];
            // 접근 메서드. datas[3] 대신 At(3)을 호출하여 접근
            // ... 구현
        }

        public void SetAt(int index, int value)         // arr[index] = value;
        {
            datas[index] = value;
        }

        private void SetArrayRandomly()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] = rand.Next(100);
            }
        }

        public bool IsContains(int value)
        {
            bool t = true;
            bool f = false;
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] == value)
                {
                    return t;
                }
            }
            return f;
            // 탐색 알고리즘을 사용하여 datas에 value가 존재하면 true, 존재하지 않으면 false 리턴
        }

        public void InsertionSort()
        {
            int value1;
            int value2;
            int index;
            for (int j = 0; j < datas.Length; j++)
            {
                index = j;
                for (int i = j; i >= 0; i--)
                {
                    if (datas[index] < datas[i])
                    {
                        value1 = datas[index];
                        value2 = datas[i];
                        datas[i] = value1;
                        datas[index] = value2;
                        index = i;
                    }
                }
            }
            // 삽입 정렬을 이용하여 datas 정렬. 내부적으로 정렬하며 외부에 반환은 하지 않음.
        }

        public void BubbleSort()
        {
            int value1;
            int value2;

            for (int j = 0; j < datas.Length; j++)
            {
                for (int i = 0; i < datas.Length - 1; i++)
                {
                    if (datas[i] > datas[i + 1])
                    {
                        value1 = datas[i];
                        value2 = datas[i + 1];
                        datas[i] = value2;
                        datas[i + 1] = value1;
                    }
                }
            }
            // 버블 정렬을 이용하여 datas 정렬. 내부적으로 정렬하며 외부에 반환은 하지 않음.
        }

        public void SelectionSort()
        {
            int value1 = 1000;
            int index = 0;
            for (int j = 0; j < datas.Length; j++)
            {
                for (int i = j; i < datas.Length; i++)
                {
                    if (datas[i] < value1)
                    {
                        value1 = datas[i];
                        index = i;
                    }
                }
                int value2 = datas[j];
                datas[index] = value2;
                datas[j] = value1;
                value1 = 1000;
                index = 0;
            }
            // 선택 정렬을 이용하여 datas 정렬. 내부적으로 정렬하며 외부에 반환은 하지 않음.
        }

        public void PrintArray()
        {
            for (int i = 0; i < datas.Length; i++)
            {
                Console.Write(datas[i] + " ");
            }
            Console.WriteLine();
        }

        public int[] ConcatArray(int[] arr1, int[] arr2)
        {
            int length1 = arr1.Length;
            int length2 = arr2.Length;
            int[] Concatarray = new int[length1 + length2];
            for (int i = 0; i < Concatarray.Length; i++)
            {
                if (i < length1)
                {
                    Concatarray[i] = arr1[i];
                }
                else
                {
                    Concatarray[i] = arr2[i - length1];
                }
            }
            return Concatarray;
            // 다른 배열과 붙이는 기능
        }

        public int[] SliceArray(int start, int end)
        {
            int[] Slice = new int[end - start + 1];
            int j = 0;  // 새로운 배열은 인덱스가 0부터 시작하므로 넣음
            for (int i = start; i <= end; i++)
            {
                Slice[j] = datas[i];
                j++;
            }
            return Slice;
            // datas 배열의 start <= index < end 에 해당하는 인덱스를 자른 배열 반환
            // Hint: end - start 사이즈 만큼의 배열을 새로 생성해서 datas에 start
            //인덱스부터 end 인덱스까지의 원소들을 새로 만든 배열에 복사하고 반환하면 되겠지
            // 예시: [3, 1, 7, 2, 5] ==SliceArray(1, 4)==> [1, 7, 2]
        }

        public void SizeUp()
        {
            int[] newArray = new int[datas.Length * 2];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < datas.Length)
                {
                    newArray[i] = datas[i];
                }
                else
                {
                    newArray[i] = 0;
                }
            }
            datas = newArray;
            // datas의 배열 사이즈가 부족할 경우 늘릴 수 있는 메서드
            // 기본으로 2배로 늘림
            // Hint: 기존배열: [3, 5, 1, 7, 2] ==SizeUp()==> [3, 5, 1, 7, 2, 0, 0, 0, 0, 0]
            // Hint: 기존 배열(datas)보다 두배 큰 배열을 생성해서 기존 배열의 값들을 복사하여 넣고 기존 배열을 대체(datas = newArray;)
        }
    }
}