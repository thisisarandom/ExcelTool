@echo off
cd config

echo "��ʼ����bytes�ļ�"
for %%i in (*.bytes) do (
    echo begin copy... %%i
    copy /y %%~nxi ..\..\hola\unity\hola_unity\Assets\Resources\Config\%%~nxi
    echo copy complate ... %%i
)
echo "bytes�ļ��������"

echo "��ʼ����cs�ļ�"
for %%i in (*.cs) do (
    echo begin copy... %%i
    copy /y %%~nxi ..\..\hola\unity\hola_unity\Assets\Src\MMHouse\Backend\Config\%%~nxi
    echo copy complate ... %%i
)
echo "cs�ļ��������"

echo "ɾ�����ɵ��ļ�"
for %%i in (*.bytes) do (
    del %%i
    echo delete complate ... %%i
)
for %%i in (*.cs) do (
    del %%i
    echo delete complate ... %%i
)
echo "ɾ�����"

pause