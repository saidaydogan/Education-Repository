#include <stdio.h>
#include <stdlib.h>
#include <time.h>
void degerleriOku(int*,int*,char*);
int** matrisOlustur(int,int);
int* yataySifrele(int**,int,int,int*);
void yatayCoz(int *,int,int,int);
int* dikeySifrele(int **,int,int,int*);
void dikeyCoz(int *,int,int,int);
void sifreliDiziKontrol(int*,int*,int*,int*,int*);
void oranHesapla(int,int);
int main()
{
    int m,n,sifreBoyut;
    int** matris;
    int* sifreliDizi;
    char yon='a';
    degerleriOku(&m,&n,&yon);
    matris=matrisOlustur(m,n);
    if(yon=='y')
    {
        sifreliDizi=yataySifrele(matris,m,n,&sifreBoyut);
        printf("\n Sifrelenmis Diziden Matris Elde Ediliyor..\n \n");
        yatayCoz(sifreliDizi,sifreBoyut,m,n);
    }
    else
    {
        sifreliDizi=dikeySifrele(matris,m,n,&sifreBoyut);
        printf("\n Sifrelenmis Diziden Matris Elde Ediliyor..\n\n");
        dikeyCoz(sifreliDizi,sifreBoyut,m,n);
    }
    oranHesapla(sifreBoyut,m*n);
    do
    {
        printf("Cikmak icin c e basin\n");
    } while( getch()!='c');


    return 0;
}
void degerleriOku(int* m,int* n,char* yon)
{
    printf("Matris boyutlarini giriniz(satir sutun sirasinda)\n");
    scanf("%d %d",m,n);
    printf("satir: %d , sutun: %d okundu.\n",*m,*n);
    do
    {
        printf("Sifreleme yapilacak yonu giriniz. (Yatay: y , Dikey: d) \n");
        do {
			scanf("%c",yon);
		}while( *yon == '\n' );
    }
    while((*yon!='y') && (*yon!='d'));
    printf("Sifreleme Yapilacan Yon: %s\n",*yon=='y'?"Yatay":"Dikey");
}
int ** matrisOlustur(int m,int n)
{
    int i,j;
    int** matris=(int**)calloc(m,sizeof(int*));
    for(i=0;i<m;i++)
    {
        matris[i]=(int *)calloc(n,sizeof(int));
    }
    srand(time(NULL));
    for(i=0;i<m;i++)
    {
        for(j=0;j<n;j++)
        {
            matris[i][j] =(rand() % 2);
            printf("%d ",matris[i][j]);
        }
        printf("\n");
    }
    return matris;
}
int * yataySifrele(int** matris,int m,int n,int* diziUzunluk)
{
    int i,j,adet=0,bakilanDeger=2;
    *diziUzunluk=2;
    int* sifreliDizi =(int*)calloc(*diziUzunluk,sizeof(int));
    bakilanDeger=matris[0][0];
    for(i=0;i<m;i++)
    {
        for(j=0;j<n;j++)
        {
            if(matris[i][j]!=bakilanDeger)
            {
                sifreliDizi[*diziUzunluk-1]=bakilanDeger;
                *diziUzunluk+=2;
                sifreliDizi=(int*)realloc(sifreliDizi,(*diziUzunluk)*sizeof(int));
                if(sifreliDizi==NULL)
                {
                    printf("Bellek genisletilemedi..\n");
                    exit(1);
                }
                bakilanDeger=matris[i][j];
                adet=1;
                sifreliDizi[*diziUzunluk-2]=adet;
                sifreliDizi[*diziUzunluk-1]=bakilanDeger;
            }
            else
            {
                adet++;
                sifreliDizi[*diziUzunluk-2]=adet;
            }
        }
    }
    printf("\nSifrelenmis Durum : \n");
    for(j=0;j<*diziUzunluk;j++)
    {
        printf("%d ", sifreliDizi[j]);
    }
    printf("\n");
    return sifreliDizi;
}
int * dikeySifrele(int** matris,int m,int n,int* diziUzunluk)
{
    int i,j,adet=0,bakilanDeger=2;
    *diziUzunluk=2;
    int* sifreliDizi =(int*)calloc(*diziUzunluk,sizeof(int));
    bakilanDeger=matris[0][0];
    for(i=0;i<n;i++)
    {
        for(j=0;j<m;j++)
        {
            if(matris[j][i]!=bakilanDeger)
            {
                sifreliDizi[*diziUzunluk-1]=bakilanDeger;
                *diziUzunluk+=2;
                sifreliDizi=(int*)realloc(sifreliDizi,(*diziUzunluk)*sizeof(int));
                if(sifreliDizi==NULL)
                {
                    printf("Bellek genisletilemedi..\n");
                    exit(1);
                }
                bakilanDeger=matris[j][i];
                adet=1;
                sifreliDizi[*diziUzunluk-2]=adet;
                sifreliDizi[*diziUzunluk-1]=bakilanDeger;
            }
            else
            {
                adet++;
                sifreliDizi[*diziUzunluk-2]=adet;
            }
        }
    }
    printf("\nSifrelenmis Durum : \n");
    for(j=0;j<*diziUzunluk;j++)
    {
        printf("%d ", sifreliDizi[j]);
    }
    printf("\n");
    return sifreliDizi;
}
void yatayCoz(int* sifreliDizi,int diziUzunluk,int m,int n)
{
    int i,j,satir=0,sutun=0;
    int atanacakDeger,adimSayisi;
    int** cozulenMatris = (int**)calloc(m,sizeof(int*));
    for(i=0;i<m;i++)
    {
        cozulenMatris[i]=(int*)calloc(n,sizeof(int));
    }
    for(i=0;i<diziUzunluk-1;i+=2)
    {
        adimSayisi=sifreliDizi[i];
        atanacakDeger=sifreliDizi[i+1];
        for(j=0;j<adimSayisi;j++)
        {
            if(sutun>=n)
            {
                satir++;
                sutun=0;
            }
            cozulenMatris[satir][sutun]=atanacakDeger;
            sutun++;
        }
    }
    for(i=0;i<m;i++)
    {
        for(j=0;j<n;j++)
        {
            printf("%d ",cozulenMatris[i][j]);
        }
        printf("\n");
    }
}
void dikeyCoz(int* sifreliDizi,int diziUzunluk,int m,int n)
{
 int i,j,satir=0,sutun=0;
    int atanacakDeger,adimSayisi;
    int** cozulenMatris = (int**)calloc(m,sizeof(int*));
    for(i=0;i<m;i++)
    {
        cozulenMatris[i]=(int*)calloc(n,sizeof(int));
    }
    for(i=0;i<diziUzunluk-1;i+=2)
    {
        adimSayisi=sifreliDizi[i];
        atanacakDeger=sifreliDizi[i+1];
        for(j=0;j<adimSayisi;j++)
        {
            if(satir>=m)
            {
                sutun++;
                satir=0;
            }
            cozulenMatris[satir][sutun]=atanacakDeger;
            satir++;
        }
    }
    for(i=0;i<m;i++)
    {
        for(j=0;j<n;j++)
        {
            printf("%d ",cozulenMatris[i][j]);
        }
        printf("\n");
    }
}
void oranHesapla(int a,int b)
{
    printf("\nSifre Uzunlugu:%d   Matris Boyut Carpimi:%d\n",a,b);
    printf("Sikisma Orani: %.3f \n\n",(float)1-((float)a/b));
}
