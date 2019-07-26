#include <iostream>
#include <fstream>
#include <stdio.h>
#include <string.h>
using namespace std;

int main(int argc, char **argv) {
	size_t bufferSize =1024;
	char    buff[bufferSize];
	char	buff2[bufferSize];
    FILE    *in, *out, *tmp;
    size_t  n,n2;
    in = fopen(argv[1],"rb");
    tmp= fopen( "tmpabcdef.raw", "wb" );
    int j=0;
    char u;
    int k=0;
    while ( ((n=fread(&u,1,1,in)) != 0 )) {
    	k++;
   		if ((u>='0' && u<='9') || (u>='a' && u<='f')) {
   	 		fwrite(&u,1,1,tmp);
		}
	}
	//cout<<k;
	fclose(tmp);
	fclose(in);
	in = fopen("tmpabcdef.raw", "rb" );
	out= fopen("haha.raw", "wb" );
    while ( (n=fread(buff,1,bufferSize,in)) != 0) {
    	//cout<<n<<endl;
    	buff[n]=='\0';
    	int i=0;
    	//cout<<buff<<endl;
    	while (i<n) {
			char c=0;
			if (buff[i]>='0' && buff[i]<='9') c=c+(buff[i]-48)*16;
			else if (buff[i]>='a' && buff[i]<='f') c=c+(buff[i]-87)*16;
			else {
				i++;
				continue;
			}
			if (buff[i+1]>='0' && buff[i+1]<='9') c=c+(buff[i+1]-48);
			else if (buff[i+1]>='a' && buff[i+1]<='f') c=c+(buff[i+1]-87);
			i+=2;
			fwrite(&c,1,1,out);
			//cout<<hex<<(unsigned int) c;
		}
    }
    fclose(in);
    fclose(out);

    return 0;
}
