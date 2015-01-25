#include <stdio.h>
#include <stdlib.h>
#include <stddef.h>
#include <ctype.h>
//DOSYA yapisi
typedef struct {
    char dosyaAdi[30];
    int paragraf;
    int cumle;
    int kelime;
    int non;
}DOSYA;
int main()
{
    DOSYA *dosyalar,*tmp;
    FILE *fp;
    int i,dSayisi;
    fp = fopen("filelist.txt","r");
    if(fp==NULL)
    {
        printf("filelist.txt acilamadi..\n");
        exit(EXIT_FAILURE);
    }
    dSayisi=0;
    while(!feof(fp))
    {
        if(dSayisi==0)
        dosyalar = (DOSYA *)calloc(1,sizeof(DOSYA));
        else
        {
            //Eger dosya sayisi 0 dan farkliysa bellekte ayrýlan yeri +1 buyutme islemi
            tmp = dosyalar;
            dosyalar = (DOSYA *)realloc(tmp,(dSayisi+1) * sizeof(DOSYA));
        }
        // "\n" almadigi icin fscanf kullanildi.
        fscanf(fp,"%s",dosyalar[dSayisi].dosyaAdi);
        dSayisi++;
    }
    fclose(fp);
    char c;
    int nonOkundu=0; // alfabetik olmayan karaktere rastlanmadigi durumu
    for(i=0;i<dSayisi;i++)
    {

        dosyalar[i].paragraf=1;
        dosyalar[i].cumle=0;
        dosyalar[i].kelime=1;
        dosyalar[i].non=0;
        fp=fopen(dosyalar[i].dosyaAdi,"r");
        while(!feof(fp))
        {

            c=getc(fp);
            if(c=='\n')
            {
                dosyalar[i].paragraf++;
                nonOkundu=0;
            }
            else if(c=='.')
            {
                dosyalar[i].cumle++;
                nonOkundu=0;
            }
            else if(c==' ')
            {
                dosyalar[i].kelime++;
                nonOkundu=0;
            }
            //Ard arda eger alfabetik olmayan karakter geliyorsa sadece 1 kere artirir.
            else if(!isalpha(c))
            {
                if(nonOkundu==0)
                {
                    //Eger bir onceki okunan karakter alfabetikse ve bu karakter alfabetik degilse alfabetik olmayan k.sayisi artiriliyor.
                    dosyalar[i].non++;
                    nonOkundu=1;
                }
            }
        }
        fclose(fp);
        printf("%s --> Paragraf Sayisi : %d, Cumle Sayisi : %d \n Kelime Sayisi : %d , Alfabetik Olmayan K.Sayisi : %d\n\n",
                    dosyalar[i].dosyaAdi,dosyalar[i].paragraf,dosyalar[i].cumle,dosyalar[i].kelime,dosyalar[i].non);
    }
    //Kullanicinin bilgilendirildigi yerde de dosyaya yazma yapilabilirdi fakat bu tercih edildi.
    fp=fopen("sonuc.txt","w");
    if(fp==NULL)
    {
        printf("sonuc.txt acilamadi..\n");
        exit(EXIT_FAILURE);
    }
    for(i=0;i<dSayisi;i++)
    {
        fprintf(fp,"%s --> Paragraf Sayisi : %d, Cumle Sayisi : %d \n Kelime Sayisi : %d , Alfabetik Olmayan K.Sayisi : %d\n\n",
        dosyalar[i].dosyaAdi,dosyalar[i].paragraf,dosyalar[i].cumle,dosyalar[i].kelime,dosyalar[i].non);
    }
    free(dosyalar);
    free(tmp);
    fclose(fp);

    return 0;
}
