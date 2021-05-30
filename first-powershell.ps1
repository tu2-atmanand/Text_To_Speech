Add-Type -AssemblyName system.speech
$voice = New-Object System.speech.Synthesis.SpeechSynthesizer
$voice.SelectVoice("Microsoft Zira Desktop")

Get-ChildItem
$null
Get-Location
$var = "Hello Github"
$var

$voice.speak($var)