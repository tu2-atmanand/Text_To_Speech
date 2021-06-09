import pyttsx3

# print("HELLO GITHUB\nThis is my first program in python to be uploaded on github.")
engine = pyttsx3.init('sapi5')
voices = engine.getProperty('voices')
# print(voices[1].id)
engine.setProperty('voice', voices[1].id)
engine.say("Hello GitHub, lets start programming in python")
engine.runAndWait()
# just edited to make a commit for specifically python
