#include<iostream>
using namespace std;
int main()
{
   int n, demuoc, demnguyento
    n=2;
    demnguyento=0;
    do
    {
    demuoc=0;
    for(int i=1;i<=n,i++)
        if(n%i==0)
           demuoc++;
    if(demuoc==2)
    {
        cout<<n<<" ";
        demnguyento++;
    }   
    n++;
  }while(demnguyento<20);
  return 0;
} 