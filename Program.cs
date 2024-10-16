﻿using System;

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
            FindSumOfEvenNumbers(10);
            FindSumOfEvenNumbers(-5);
            FindSumOfEvenNumbers(2);
            FindSumOfEvenNumbers(0);
            FindSumOfEvenNumbers(1);
            FindSumOfEvenNumbers(25);
            FindSumOfEvenNumbers(-25);
            FindSumOfOddNumbers(10);
            FindSumOfOddNumbers(-5);
            FindSumOfOddNumbers(1);
            FindSumOfOddNumbers(2);
            FindSumOfOddNumbers(25);
            FindSumOfOddNumbers(-25);
            OutputRightTriangle(4);
            OutputRightTriangle(6);
            OutputRightTriangle(-4);
            OutputRightTriangle(-6);
            OutputRightTriangle(0);

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
            if(n==0 || n==-1 || n==1){
                Console.WriteLine("0");
            } else if (1<n){
                int sum=0;
                int counter=1;
                while(counter<=n){
                    if(counter % 2 ==0){
                        sum+= counter;
                    }
                    counter++;
                }
                Console.WriteLine(sum);
            } else if(n<=1) {
                int sum=0;
                int counter=1;
                while(counter>n){
                    if(counter % 2 ==0){
                        sum+= counter;
                    }
                    counter--;
                }
                Console.WriteLine(sum);
            }
        }
        static void FindSumOfOddNumbers(int n){
            if(n==0){
                Console.WriteLine("0");
            } else if(n==-1 || n==1) {
                Console.WriteLine("1");
            } else if (1<n){
                int sum=0;
                int counter=1;
                while(counter<=n){
                    if(counter % 2 !=0){
                        sum+= counter;
                    }
                    counter++;
                }
                Console.WriteLine(sum);
            } else if(n<=1) {
                int sum=0;
                int counter=1;
                while(counter>=n){
                    if(counter % 2 !=0){
                        sum+= counter;
                    }
                    counter--;
                }
                Console.WriteLine(sum);
            }
        }
        static void OutputRightTriangle(int _base){
            if(_base==0){
                OutOfRangeMessage(0);
            } else if (_base>1){
                int numOfStars = 1;
                int startNum=1;
                while(startNum<=_base){
                    for(int startNum2=1; startNum2<=numOfStars;startNum2++){
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    numOfStars++;
                    startNum++;
                }
            } else if(_base<1){
                int numOfStars = _base;
                int startNum=1;
                while(startNum>=_base){
                    for(int startNum2=1; startNum2>=numOfStars;startNum2--){
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    numOfStars++;
                    startNum--;
                }
            }
        }
        static void OutOfRangeMessage(int n){
            Console.WriteLine(n+" is out of range.");
        }
    }
}