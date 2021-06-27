import pyvisa
import time
import locale
locale.setlocale(locale.LC_ALL, 'turkish')

say=0

rm = pyvisa.ResourceManager()
print("USB Cihazlar:\t",rm.list_resources()) # visa usb port okuma 
usb=list(rm.list_resources())# usb port listesi

zaman=str(time.strftime('%c'))#sistem zman bilgisi okuma

seriNo=str(input("Cihaz seri nunarasını okutunuz:"))
dosya=open(seriNo+".txt","at")
dosya.write(zaman+"\n")
dosya.close()

for i in usb:
    say=say+1
    if i in "ASRL11::INSTR":
        print(i)
        inst = rm.open_resource(i)#belirtilen usb portu açma 
        time.sleep(0.5)
        break
    elif say==len(usb):
        print("Deger bulunamadi")

deger=input("bir deger giriniz:")
inst.write(deger) # usb porta data gönderme


try:
    data_oku=inst.query("*IDN?")
    print(data_oku)
    dosya.write(data_oku+"\n")
    dosya.close()
    
    
except:
    print("Veri okanamadi!")
    dosya=open(seriNo+".txt","at")
    dosya.write("USB port okuma hatası!!\n")
    dosya.close()
    






 