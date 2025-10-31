number = 10
number = "Hello" #This is allowed (the type changes at runtime)
print(number)

x = 5
y = "10"
#print(x+y) Type Error; this is unsupported
print(x + int(y))

class Dog:
    def speak(self): print("Woof!")

class Cat:
    def speak(self): print("Meow!")

def make_animal_speak(animal):
    animal.speak() #works as long as "speak" exists

make_animal_speak(Dog())
make_animal_speak(Cat()) #both works; no interface needed