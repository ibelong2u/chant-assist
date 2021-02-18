'chant assist - Aditya (email@aditya.com)
'Jai Guru Dev!

set wshShell = Wscript.CreateObject("wscript.Shell")
beep = chr(007)

Do

box = msgbox("Press spacebar or click button to start timer."+ Chr(13) + "Begin chant immediately after...",0,"How long is your single chant?")
x = Now

box = msgbox("Complete the chant and press to stop timer.",0,"Setting chant interval...")
y = Now

z=y-x
interval = Second(z)

if interval = 0 then
interval = 1
end if

box = msgbox("Your single chant is " + Cstr(interval) + " seconds!" + Chr(13) + "Press 'OK' to continue or 'Cancel' to Reset interval.",1,"Done!" )

' Ok:1
' Cancel:2

Loop While box=2

beads = inputbox("How many times would you like to chant?" + Chr(13) + Chr(13) + "Press OK to begin chanting!", "Set the duration...", "108")

Set WshShell = WScript.CreateObject("WScript.Shell") 

for i = beads to 1 step -1
WshShell.Popup "Number of times remaing: " + Cstr(i), interval
WshShell.Run "cmd /c @echo " & beep, 0
next

WshShell.Run "cmd /c @echo " & beep, 0
WshShell.Popup "Congratulations, you just finished chanting " + Cstr(beads) + " times!", 1
WshShell.Run "cmd /c @echo " & beep, 0
WshShell.Popup "Thank you for using this program!", 1
WshShell.Run "cmd /c @echo " & beep, 0



