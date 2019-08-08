@Echo Off
Net Stop OpenVPNService
PING -n 1 -w 10000 192.168.253.253 > nul
:ReStartService
Net Start OpenVPNService
SC query OpenVPNService | find /i "1  STOPPED" > nul
if %errorlevel%==0 echo GoTo ReStartService
EXIT