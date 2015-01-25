#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define sayiSayisi 1000000
void kabarcikSiralama(int*,int);
void secerekSiralama(int*,int);
int main()
{

    srand(time(NULL));
    int* sayilar = malloc( sayiSayisi * sizeof( int) );
    int* sayilar2 = malloc( sayiSayisi * sizeof( int) );
    int i,r;
    for(i=0;i<sayiSayisi;i++)
    {
        r=rand();
        sayilar[i]=r;
        sayilar2[i]=r;
    }
    printf("%d adet rastgele sayi uretildi\n",sayiSayisi);

    clock_t baslangic;
    clock_t bitis;
    double gecenSure;
    printf("Kabarcik siralama baslatildi.\n");
    baslangic = clock();
    kabarcikSiralama(sayilar,sayiSayisi);
    free(sayilar);
    bitis = clock();
    gecenSure=(double)(bitis-baslangic)/CLOCKS_PER_SEC;
    printf("Kabarcik Siralama Suresi : %.2lf sn\n",gecenSure);
    printf("Secerek siralama baslatildi.\n");
    baslangic = clock();
    secerekSiralama(sayilar2,sayiSayisi);
    free(sayilar2);
    bitis = clock();
    gecenSure=(double)(bitis-baslangic)/CLOCKS_PER_SEC;
    printf("Secerek Siralama Suresi : %.2lf sn\n",gecenSure);

    return 0;
}
void kabarcikSiralama(int* dizi,int buyukluk)
{
    int i,j,t;
    for(i=0;i<buyukluk-1;i++)
    {
        for(j=1;j<buyukluk-1-i;j++)
        {
            if(dizi[j]>dizi[j-1])
            {
               t=dizi[j];
               dizi[j]=dizi[j-1];
               dizi[j-1]=t;
            }
        }
    }
}
void secerekSiralama(int* dizi,int buyukluk)
{
    int i,j,t;
    for(i=0;i<buyukluk-1;i++)
    {
        for(j=i+1;j<buyukluk;j++)
        {
            if(dizi[i]<dizi[j])
             {
                t=dizi[i];
                dizi[i]=dizi[j];
                dizi[j]=t;
             }
        }
    }
}
