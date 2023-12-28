#Code a basic incryption 
text = 'Hello World'
shift = 3
alphabet = 'abcdefghijklmnopqrstuvwxyz'
#print(index)

for char in text.lower(): 
    
    index = alphabet.find(char)
    new_index = index + shift
    encryption =  alphabet[new_index]
    print("char:", char, "encryption:", encryption)