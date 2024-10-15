using System;

namespace loop_iteration_practice_Andrew_Creswick{
    class Program{
        static void Main(string[] args){
            Write1ThroughN_While(-1);
            Write1ThroughN_While(5);
            Write1ThroughN_While(0);
            Write1ThroughN_For(-1);
            Write1ThroughN_For(5);
            Write1ThroughN_For(0);
            WriteNThrough1_While(-1);
            WriteNThrough1_While(5);
            WriteNThrough1_While(0);
            WriteNThrough1_For(-1);
            WriteNThrough1_For(5);
            WriteNThrough1_For(0);
            WriteEvensThrough100();
            FindSum(5);
            FindSum(1);
            FindSum(-3);
            FindSum(100);
        }
        static void Write1ThroughN_While(int n){
            if(n<1){
                OutOfRangeMessage(n);
            } else {
                int starterNum = 1;
                while(starterNum<=n){
                    if(starterNum==n){
                        Console.WriteLine(starterNum);
                    } else {
                        Console.Write(starterNum+" ");
                    }
                    starterNum++;
                }
            }
        }
        static void Write1ThroughN_For(int n){
            if(n<1){
                OutOfRangeMessage(n);
            } else {
                for(int starterNum = 1; starterNum<=n;starterNum++){
                    if(starterNum==n){
                        Console.WriteLine(starterNum);
                    } else {
                        Console.Write(starterNum+" ");
                    }
                }
            }
        }
        static void WriteNThrough1_While(int n){
            if(n<1){
                OutOfRangeMessage(n);
            } else {
                int endingNum = 1;
                int mathN = n;
                while(mathN>=endingNum){
                    if(mathN==endingNum){
                        Console.WriteLine(mathN);
                    } else {
                        Console.Write(mathN+" ");
                    }
                    mathN--;
                }
            }
        }
        static void WriteNThrough1_For(int n){
            if(n<1){
                OutOfRangeMessage(n);
            } else {
                int endingNum = 1;
                for(int mathN=n; mathN>=endingNum;mathN--){
                    if(mathN==endingNum){
                        Console.WriteLine(mathN);
                    } else {
                        Console.Write(mathN+" ");
                    }
                }
            }
        }
        static void WriteEvensThrough100(){
            int endingNum = 100;
            for(int starterNum = 2; starterNum<=endingNum;starterNum=starterNum+2){
                if(starterNum==endingNum){
                    Console.WriteLine(starterNum);
                } else {
                    Console.Write(starterNum+" ");
                }
            }
        }
        static void FindSum(int n){
            if(n==0){
                Console.WriteLine("0");
            } else if(1<n) {
                int starterNum = 1;
                int nextNum = 2;
                for(int i = 1;i<n;i++){
                    starterNum=starterNum+nextNum;
                    nextNum++;
                }
                Console.WriteLine(starterNum);
            } else {
                int starterNum = 1;
                int nextNum=-1;
                for(int i = 0;i>n;i--){
                    starterNum=starterNum+nextNum;
                    nextNum--;
                }
                Console.WriteLine(starterNum);
            }
        }
        static void FindSumOfEvenNumbers(int n){
            
        }
        static void FindSumOfOddNumbers(int n){
            
        }
        static void OutputRightTriangle(int _base){
            
        }
        static void OutOfRangeMessage(int n){
            Console.WriteLine(n+" is out of range.");
        }
    }
}