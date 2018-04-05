using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenMath_MD.Dna
{
    class Listprob
    {
            //problem.Cases.Add(new Case(1, 4, sum(1, 4)));
            //problem.Cases.Add(new Case(1, 3, sum(1, 3)));
            //problem.Cases.Add(new Case(1, 2, sum(1, 2)));
            //problem.Cases.Add(new Case(1, 6, sum(1, 6)));
            //problem.Cases.Add(new Case(1, 5, sum(1, 5)));

			//problem.Cases.Add(new Case(1,2,448));
			//problem.Cases.Add(new Case(2,3,616));
			//problem.Cases.Add(new Case(3,4,1360));
			//problem.Cases.Add(new Case(4,5,5052));
			//problem.Cases.Add(new Case(5,6,20168));
			//problem.Cases.Add(new Case(6,7,141128));
			//problem.Cases.Add(new Case(7,8,1128968));
			//problem.Cases.Add(new Case(8,9,5080324));
			//problem.Cases.Add(new Case(9,10,50803204));
			//problem.Cases.Add(new Case(10,11,558835204));


			
			//double y = 4;
            //double q = 0;
            //double lambda = q; //lambda*...
            //for (double i = 1; i < y; i += 1)
            //{
            //	double t = 0;


            //    while (q < i) //while -> sum_(q=1)^n (q^lambda-(q-1)^(lambda)) 
            //{
            //	++q;
            //   lambda = q+1;
            //	int p = 0;
            //	while(p < q)
            //	{
            //		++p;
            //		t = t+(Math.Pow(p,lambda))-(Math.Pow((p-1),lambda)); //a^n ? prod(i=1,a,n)
            //	}

            //}
            //problem.Cases.Add(new Case(i, lambda, t)); //pr sum(q³) from y = p = 1 to i = (sum(q))² from y = p = 1 to i
            //}
			


			//problem.Cases.Add(new Case(6,1, Math.Pow(6, 4)*Math.Pow(5,4)));
			//problem.Cases.Add(new Case(5,1, Math.Pow(5, 4)*Math.Pow(4,4)));
			//problem.Cases.Add(new Case(4,3, Math.Pow(4, 3)));

			//problem.Cases.Add(new Case(0,1,1));
			//problem.Cases.Add(new Case(1,1,1));
			//problem.Cases.Add(new Case(2,1,2));
			//problem.Cases.Add(new Case(3,1,6));
			//problem.Cases.Add(new Case(4,1,24));
			//problem.Cases.Add(new Case(5,1,120));
			//problem.Cases.Add(new Case(6,1,720)); //n!

			//problem.Cases.Add(new Case(2, 1, Math.Sqrt(2)));
			//problem.Cases.Add(new Case(16, 1,Math.Sqrt(16)));

			//problem.Cases.Add(new Case(1,2,Math.Pow(2.7182818284,2))); //e²

			//int y = 10;
			//int q = 0;
			//int lambda = 10; //lambda*...
			//Problem problem = new Problem();
			//for (double i = 1; i < y; i += 1)
			//{
			//	int t = 0;


				//while(q < i) //while -> lambda*sum(q^d) from y = p = 1 to i
				//{
				//	++q;
				//	int p = 0;
			    //	while(p < q)
				//	{
				//		++p;
				//		t = t+p*p*p; //a^n ≠ prod(i=1,a,n)
				//	}
				//	t = lambda * t;

				//}
				//problem.Cases.Add(new Case(i, 1, t)); //pr sum(q³) from y = p = 1 to i = (sum(q))² from y = p = 1 to i
			//}

			//double t = ((i * ((i + 1) * (2 * i + 1))) / 2); //3(sum(n²))

			//problem.Cases.Add(new Case(8, 4, 60));
			//problem.Cases.Add(new Case(9, 6, 75)); //x²-y                                                              
			//problem.Cases.Add(new Case(256, 6, 65530));

			//problem.Cases.Add(new Case(6, 7, 6480000));
			//problem.Cases.Add(new Case(6, 12, 10530000)); //k^4(k-1)(m+1)
			//problem.Cases.Add(new Case(4, 3, 82944));
			//problem.Cases.Add(new Case(2, 2, 48));
			//problem.Cases.Add(new Case(3, 4, 6480));

			//problem.Cases.Add(new Case(5, 1, 55));
			//problem.Cases.Add(new Case(6, 1, 91));
			//problem.Cases.Add(new Case(10, 1, 385)); //1/6n(n+1)(2n+1)
			//problem.Cases.Add(new Case(16, 1, 1496));
			//problem.Cases.Add(new Case(19, 1, 2470));
			
            //problem.Cases.Add(new Case(10, 1, 55));
			//problem.Cases.Add(new Case(12, 1, 78));
			//problem.Cases.Add(new Case(17, 1, 153)); //(n²+n)/2

            //problem.Cases.Add(new Case(6, 3, (pgcd(6,3))*6));
            //problem.Cases.Add(new Case(81, 9, (pgcd(81, 9))*81));
            //problem.Cases.Add(new Case(5, 25, (pgcd(5, 25))*5));
            //problem.Cases.Add(new Case(5, 26, (pgcd(5, 26))*5));
            //problem.Cases.Add(new Case(9, 81, (pgcd(9, 81))*9));

			//problem.Cases.Add(new Case(4, 0, 20736));
			//problem.Cases.Add(new Case(5, 0, 160000));

			//problem.Cases.Add(new Case(9, 3, 495));
			//problem.Cases.Add(new Case(3, 5, 69));
			//problem.Cases.Add(new Case(3, 7, 75));
			//problem.Cases.Add(new Case(2, 7, 45)); //6x²+3y

			//problem.Cases.Add(new Case(47, 3, 533));
			//problem.Cases.Add(new Case(30, 5, 365));
			//problem.Cases.Add(new Case(15, 7.5, 217.5)); //10(x+6)+y


			//problem.Cases.Add(new Case(2, 1, Math.PI * 2 + 1));
			//problem.Cases.Add(new Case(5, 2, Math.PI * 5 + 2));
			//problem.Cases.Add(new Case(9, 3, Math.PI * 9 + 3));
			//problem.Cases.Add(new Case(7325, 4, Math.PI * 7325 + 4));
			//problem.Cases.Add(new Case(4, 5, 625));
			//problem.Cases.Add(new Case(3, 7, 784));
			//problem.Cases.Add(new Case(6, 14, 9604));
			//problem.Cases.Add(new Case(8, 4, 1296)); 

			//problem.Cases.Add(new Case(9, 0, 6561));
			//problem.Cases.Add(new Case(2, 2, 48));
			//problem.Cases.Add(new Case(3, 2, 64));
			//problem.Cases.Add(new Case(4, 2, 80));
			//problem.Cases.Add(new Case(5, 2, 96));
			//problem.Cases.Add(new Case(6, 2, 112));
			//problem.Cases.Add(new Case(7, 2, 128));
			//problem.Cases.Add(new Case(8, 2, 144));
			//problem.Cases.Add(new Case(9, 2, 160));
			//problem.Cases.Add(new Case(10, 2, 176));
			//problem.Cases.Add(new Case(2, 3, 3888));
			//problem.Cases.Add(new Case(1, 255, 1 + 1));
			//problem.Cases.Add(new Case(2, 255, 2 + 1));
			//problem.Cases.Add(new Case(1, 0, 0 + 1));
			//problem.Cases.Add(new Case(1, 2, 0 + 1));
			//problem.Cases.Add(new Case(16, 16, 16 + 1));
			//problem.Cases.Add(new Case(16, 255, 16 + 1));
			//problem.Cases.Add(new Case(17, 255, 17 + 1));

			//problem.Cases.Add(new Case(1, 5, 55));
			//problem.Cases.Add(new Case(3, 6, 63));
			//problem.Cases.Add(new Case(7, 7, 78));
			//problem.Cases.Add(new Case(13, 5, 99));

			//for (int i = 0; i < 16; i++)
			//{
			//    string tmp = Convert.ToString(i, 2);
			//    int res = int.Parse(tmp);
			//    problem.Cases.Add(new Case(i, 0, res));
			//}


			//for (double i = 0; i < Math.PI * 2; i += 1)
			//{
			//    problem.Cases.Add(new Case(i, 0, Math.Sin(i) * 100));
			//}

        //problem.Cases.Add(new Case(36, 6, pgcd(36, 6)));
            //problem.Cases.Add(new Case(93, 27, pgcd(93, 27)));
    }
}
