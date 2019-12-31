Comparison.destroy_all
LanguagePhoneme.destroy_all
Language.destroy_all
LanguageFamily.destroy_all
Morphology.destroy_all
Orthography.destroy_all
Phoneme.destroy_all

#LANGUAGE FAMILIES
germanic = LanguageFamily.create(
    specific_family:"Germanic",
    general_family:"Indo-European",
    x_coordinate:55.097230,
    y_coordinate:4.737163,
)
italic = LanguageFamily.create(
    specific_family:"Italic",
    general_family:"Indo-European",
    x_coordinate:41.164182,
    y_coordinate:7.288966,
)
koreanic = LanguageFamily.create(
    specific_family:"Koreanic",
    general_family:"*Language-Isolate",
    x_coordinate:38.274575,
    y_coordinate:127.436801,
)
japonic = LanguageFamily.create(
    specific_family:"Japanese",
    general_family:"Japonic",
    x_coordinate:38.555683,
    y_coordinate:140.238261,
)
sinitic = LanguageFamily.create(
    specific_family:"Sinitic",
    general_family:"Sino-Tibetan",
    x_coordinate:29.676122,
    y_coordinate:-253.065067,
)
polynesian= LanguageFamily.create(
    specific_family:"Polynesian",
    general_family:"Austronesian",
    x_coordinate:19.338034,
    y_coordinate:-155.565148,
)
semitic = LanguageFamily.create(
    specific_family:"Semitic",
    general_family:"Afro-Asiatic",
    x_coordinate:26.391870,
    y_coordinate:34.759093,
)
benue = LanguageFamily.create(
    specific_family:"Benue-Congo",
    general_family:"Bantu",
    x_coordinate:-12.052751,
    y_coordinate:-329.672184,
)
athabaskan = LanguageFamily.create(
    specific_family:"Athabaskan",
    general_family:"Na-Dene",
    x_coordinate:37.463959,
    y_coordinate:-477.705883,
)
#MORPHOLOGIES
polysynthetic = Morphology.create(name: "polysynthetic", coordinate_value: 5)
agglutinative = Morphology.create(name: "agglutinative", coordinate_value: 4)
fusional = Morphology.create(name: "fusional", coordinate_value: 3)
analytic = Morphology.create(name: "analytic", coordinate_value: 0)

#ORTHOGRAPHIES
latin = Orthography.create(
    name:"the Latin alphabet",
    system:"alphabetic (every symbol represents a consonant or vowel)",
    coordinate_value: 1,
)

kana = Orthography.create(
    name:"a combination of Kanji and Kana(Hirigana and Katakana)",
    system:"Kanji is logographic (each symbol represents a word), Kana is syllabic (each symbol represents a syllable)",
    coordinate_value: 3,
)
arabic_script = Orthography.create(
    name:"Arabic script",
    system:"abjad (each symbol represents a consonant, so the reader must supply the appropriate vowel)",
    coordinate_value: 4,
)

hangul = Orthography.create(
    name:"Hangul",
    system:"syllabic (each symbol represents a syllable)",
    coordinate_value: 2,
)
hanzi = Orthography.create(
    name:"Hanzi",
    system:"logographic (each symbol represents both a word and a sound)",
    coordinate_value: 5,
)


#PHONEMES

p = Phoneme.create(
    symbol: "p",
    place: "bilabial",
    manner: "plosive",
    category: "consonant",
)
b = Phoneme.create(
    symbol: "b",
    place: "bilabial",
    manner: "plosive",
    category: "consonant",
)
t = Phoneme.create(
    symbol: "t",
    place: "alveolar",
    manner: "plosive",
    category: "consonant",
)
d = Phoneme.create(
    symbol: "d",
    place: "alveolar",
    manner: "plosive",
    category: "consonant", 
)
ʈ = Phoneme.create(
    symbol: "ʈ",
    place: "retroflex",
    manner: "plosive",
    category: "consonant",
)
ɖ = Phoneme.create(
    symbol: "ɖ",
    place: "retroflex",
    manner: "plosive",
    category: "consonant",
    
)
tɬ = Phoneme.create(
    symbol: "tɬ",
    place: "alveolar",
    manner: "plosive",
    category: "consonant",
    
)
m = Phoneme.create(
    symbol: "m",
    place: "bilabial",
    manner: "nasal",
    category: "consonant",
    
)
ɱ = Phoneme.create(
    symbol: "ɱ",
    place: "labiodental",
    manner: "nasal",
    category: "consonant",
    
)
n = Phoneme.create(
    symbol: "n",
    place: "alveolar",
    manner: "nasal",
    category: "consonant",
    
)
ɳ = Phoneme.create(
    symbol: "ɳ",
    place: "retroflex",
    manner: "nasal",
    category: "consonant",
    
)
ʙ = Phoneme.create(
    symbol: "ʙ",
    place: "bilabial",
    manner: "trill",
    category: "consonant",
    
)
r = Phoneme.create(
    symbol: "r",
    place: "alveolar",
    manner: "trill",
    category: "consonant",
    
)
ɾ = Phoneme.create(
    symbol: "ɾ",
    place: "alveolar",
    manner: "tap",
    category: "consonant",
    
)
ɽ = Phoneme.create(
    symbol: "ɽ",
    place: "retroflex",
    manner: "tap",
    category: "consonant",
    
)
ɸ = Phoneme.create(
    symbol: "ɸ",
    place: "bilabial",
    manner: "fricative",
    category: "consonant",
    
)
β = Phoneme.create(
    symbol: "β",
    place: "bilabial",
    manner: "fricative",
    category: "consonant",
    
)
f = Phoneme.create(
    symbol: "f",
    place: "labiodental",
    manner: "fricative",
    category: "consonant",
)
v = Phoneme.create(
    symbol: "v",
    place: "labiodental",
    manner: "fricative",
    category: "consonant",
)
θ = Phoneme.create(
    symbol: "θ",
    place: "dental",
    manner: "fricative",
    category: "consonant",
)
ð = Phoneme.create(
    symbol: "ð",
    place: "dental",
    manner: "fricative",
    category: "consonant",
)
s = Phoneme.create(
    symbol: "s",
    place: "alveolar",
    manner: "fricative",
    category: "consonant",
)
z = Phoneme.create(
    symbol: "z",
    place: "alveolar",
    manner: "fricative",
    category: "consonant",
)
ʃ = Phoneme.create(
    symbol: "ʃ",
    place: "post-alveolar",
    manner: "fricative",
    category: "consonant",
)
ʒ = Phoneme.create(
    symbol: "ʒ",
    place: "post-alveolar",
    manner: "fricative",
    category: "consonant",
)
ʂ = Phoneme.create(
    symbol: "ʂ",
    place: "retroflex",
    manner: "fricative",
    category: "consonant",
)
ʐ = Phoneme.create(
    symbol: "ʐ",
    place: "retroflex",
    manner: "fricative",
    category: "consonant",
)
ɬ = Phoneme.create(
    symbol: "ɬ",
    place: "alveolar",
    manner: "lateral fricative",
    category: "consonant",
)
ɮ = Phoneme.create(
    symbol: "ɮ",
    place: "alveolar",
    manner: "lateral fricative",
    category: "consonant",
)
ʋ = Phoneme.create(
    symbol: "ʋ",
    place: "labiodental",
    manner: "approximant",
    category: "consonant",
)
ɹ = Phoneme.create(
    symbol: "ɹ",
    place: "alveolar",
    manner: "approximant",
    category: "consonant",
)
ɻ = Phoneme.create(
    symbol: "ɻ",
    place: "retroflex",
    manner: "approximant",
    category: "consonant",
)
l = Phoneme.create(
    symbol: "l",
    place: "alveolar",
    manner: "lateral approximant",
    category: "consonant",
)
ɭ = Phoneme.create(
    symbol: "ɭ",
    place: "retroflex",
    manner: "lateral approximant",
    category: "consonant",
)
c = Phoneme.create(
    symbol: "c",
    place: "palatal",
    manner: "plosive",
    category: "consonant",
)
ɟ = Phoneme.create(
    symbol: "ɟ",
    place: "palatal",
    manner: "plosive",
    category: "consonant",
)
k = Phoneme.create(
    symbol: "k",
    place: "velar",
    manner: "plosive",
    category: "consonant",
)
g = Phoneme.create(
    symbol: "g",
    place: "velar",
    manner: "plosive",
    category: "consonant",
)
q = Phoneme.create(
    symbol: "q",
    place: "uvular",
    manner: "plosive",
    category: "consonant",
)
ɢ = Phoneme.create(
    symbol: "ɢ",
    place: "uvular",
    manner: "plosive",
    category: "consonant",
)
ʔ = Phoneme.create(
    symbol: "ʔ",
    place: "glottal",
    manner: "plosive",
    category: "consonant",
)
ɲ = Phoneme.create(
    symbol: "ɲ",
    place: "palatal",
    manner: "nasal",
    category: "consonant",
)
ŋ = Phoneme.create(
    symbol: "ŋ",
    place: "velar",
    manner: "nasal",
    category: "consonant",
)
ɴ = Phoneme.create(
    symbol: "ɴ",
    place: "uvular",
    manner: "nasal",
    category: "consonant",
)
ʀ = Phoneme.create(
    symbol: "ʀ",
    place: "uvular",
    manner: "trill",
    category: "consonant",

)
ç = Phoneme.create(
    symbol: "ç",
    place: "palatal",
    manner: "fricative",
    category: "consonant",
)
ʝ = Phoneme.create(
    symbol: "ʝ",
    place: "palatal",
    manner: "fricative",
    category: "consonant",
)
x = Phoneme.create(
    symbol: "x",
    place: "velar",
    manner: "fricative",
    category: "consonant",
)
ɣ = Phoneme.create(
    symbol: "ɣ",
    place: "velar",
    manner: "fricative",
    category: "consonant",
)
χ = Phoneme.create(
    symbol: "χ",
    place: "uvular",
    manner: "fricative",
    category: "consonant",
)
ʁ = Phoneme.create(
    symbol: "ʁ",
    place: "uvular",
    manner: "fricative",
    category: "consonant",
)
ħ = Phoneme.create(
    symbol: "ħ",
    place: "pharyngeal",
    manner: "fricative",
    category: "consonant",
)
ʕ = Phoneme.create(
    symbol: "ʕ",
    place: "pharyngeal",
    manner: "fricative",
    category: "consonant",
)
h = Phoneme.create(
    symbol: "h",
    place: "glottal",
    manner: "fricative",
    category: "consonant",
)
ɦ = Phoneme.create(
    symbol: "ɦ",
    place: "glottal",
    manner: "fricative",
    category: "consonant",
)
j = Phoneme.create(
    symbol: "j",
    place: "palatal",
    manner: "approximant",
    category: "consonant",
)
ɰ = Phoneme.create(
    symbol: "ɰ",
    place: "velar",
    manner: "approximant",
    category: "consonant",
)
ʎ = Phoneme.create(
    symbol: "ʎ",
    place: "palatal",
    manner: "lateral approximant",
    category: "consonant",
)
ʟ = Phoneme.create(
    symbol: "ʟ",
    place: "velar",
    manner: "lateral approximant",
    category: "consonant",
)
w = Phoneme.create(
    symbol: "w",
    place: "labio-velar",
    manner: "approximant",
    category: "consonant",
)
#end pulmonic consts
ʘ = Phoneme.create(
    symbol: "ʘ",
    place: "bilabial",
    manner: "click",
    category: "consonant",
)
ǀ = Phoneme.create(
    symbol: "ǀ",
    place: "dental",
    manner: "click",
    category: "consonant",
)
bang = Phoneme.create(
    symbol: "!",
    place: "alveolar",
    manner: "click",
    category: "consonant",
)
ǂ = Phoneme.create(
    symbol: "ǂ",
    place: "palato-alveolar",
    manner: "click",
    category: "consonant",
)
ǁ = Phoneme.create(
    symbol: "ǁ",
    place: "alveolar lateral",
    manner: "click",
    category: "consonant",
)
ɓ = Phoneme.create(
    symbol: "ɓ",
    place: "bilabial",
    manner: "implosive",
    category: "consonant",
)
ɗ = Phoneme.create(
    symbol: "ɗ",
    place: "dental",
    manner: "implosive",
    category: "consonant",
)
ʄ = Phoneme.create(
    symbol: "ʄ",
    place: "palatal",
    manner: "implosive",
    category: "consonant",
)
ɠ = Phoneme.create(
    symbol: "ɠ",
    place: "velar",
    manner: "implosive",
    category: "consonant",
)
ʛ = Phoneme.create(
    symbol: "ʛ",
    place: "uvular",
    manner: "implosive",
    category: "consonant",
)
◌ʼ = Phoneme.create(
    symbol: "◌ʼ",
    manner: "ejective",
    category: "consonant",
)
◌ˤ = Phoneme.create(
    symbol: "◌ˤ",
    manner: "pharyngealization",
    category: "consonant",
)
#end non-pulmonic
#start affricates
t͡s = Phoneme.create(
    symbol: "t͡s",
    place: "alveolar",
    manner: "affricate",
    category: "consonant",
)
t͡ʃ = Phoneme.create(
    symbol: "t͡ʃ",
    place: "palato-alveolar",
    manner: "affricate",
    category: "consonant",
)
t͡ɕ = Phoneme.create(
    symbol: "t͡ɕ",
    place: "alveolo-palatal",
    manner: "affricate",
    category: "consonant",
)
ʈ͡ʂ = Phoneme.create(
    symbol: "ʈ͡ʂ",
    place: "retroflex",
    manner: "affricate",
    category: "consonant",
)
d͡z = Phoneme.create(
    symbol: "d͡z",
    place: "alveolar",
    manner: "affricate",
    category: "consonant",
)
d͡ʒ = Phoneme.create(
    symbol: "d͡ʒ",
    place: "post-alveolar",
    manner: "affricate",
    category: "consonant",
)
d͡ʑ = Phoneme.create(
    symbol: "d͡ʑ",
    place: "alveolo-palatal",
    manner: "affricate",
    category: "consonant",
)
ɖ͡ʐ = Phoneme.create(
    symbol: "ɖ͡ʐ",
    place: "retroflex",
    manner: "affricate",
    category: "consonant",
)
p̪͡f = Phoneme.create(
    symbol: "p̪͡f",
    place: "labiodental",
    manner: "affricate",
    category: "consonant",
)
ɟʝ = Phoneme.create(
    symbol: "ɟʝ",
    place: "palatal",
    manner: "affricate",
    category: "consonant",
)

#end affricates
#begin "other"
ɥ = Phoneme.create(
    symbol: "ɥ",
    place: "labio-palatal",
    manner: "approximant",
    category: "consonant",
)
ʜ = Phoneme.create(
    symbol: "ʜ",
    place: "epiglottal",
    manner: "fricative",
    category: "consonant",
)
ʢ = Phoneme.create(
    symbol: "ʢ",
    place: "epiglottal",
    manner: "fricative",
    category: "consonant",
)
ʡ = Phoneme.create(
    symbol: "ʡ",
    place: "epiglottal",
    category: "consonant",
)
ɕ = Phoneme.create(
    symbol: "ɕ",
    place: "alveolo-palatal",
    manner: "fricative",
    category: "consonant",
)
ʑ = Phoneme.create(
    symbol: "ʑ",
    place: "alveolo-palatal",
    manner: "fricative",
    category: "consonant",
)
ɺ = Phoneme.create(
    symbol: "ɺ",
    place: "alveolar",
    manner: "lateral flap",
    category: "consonant",
)
ɧ = Phoneme.create(
    symbol: "ɧ",
    place: "post-alveolar-velar",
    manner: "fricative",
    category: "consonant",
)
#end "other"
# begin basic vowels
i = Phoneme.create(
    symbol: "i",
    place: "front",
    manner: "close",
    category: "vowel",
)
y = Phoneme.create(
    symbol: "y",
    place: "front",
    manner: "close",
    category: "vowel",
)
ɨ = Phoneme.create(
    symbol: "ɨ",
    place: "central",
    manner: "close",
    category: "vowel",
)
ʉ = Phoneme.create(
    symbol: "ʉ",
    place: "central",
    manner: "close",
    category: "vowel",
)
ɯ = Phoneme.create(
    symbol: "ɯ",
    place: "back",
    manner: "close",
    category: "vowel",
)
u = Phoneme.create(
    symbol: "u",
    place: "back",
    manner: "close",
    category: "vowel",
)
ɪ = Phoneme.create(
    symbol: "ɪ",
    place: "near-front",
    manner: "near-close",
    category: "vowel",
)
ʏ = Phoneme.create(
    symbol: "ʏ",
    place: "near-front",
    manner: "near-close",
    category: "vowel",
)
ʊ = Phoneme.create(
    symbol: "ʊ",
    place: "near-back",
    manner: "near-close",
    category: "vowel",
)
e = Phoneme.create(
    symbol: "e",
    place: "front",
    manner: "close-mid",
    category: "vowel",
)
ø = Phoneme.create(
    symbol: "ø",
    place: "near-front",
    manner: "close-mid",
    category: "vowel",
)
ɘ = Phoneme.create(
    symbol: "ɘ",
    place: "central",
    manner: "close-mid",
    category: "vowel",
)
ɵ = Phoneme.create(
    symbol: "ɵ",
    place: "near-back",
    manner: "close-mid",
    category: "vowel",
)
ɤ = Phoneme.create(
    symbol: "ɤ",
    place: "back",
    manner: "close-mid",
    category: "vowel",
)
o = Phoneme.create(
    symbol: "o",
    place: "back",
    manner: "close-mid",
    category: "vowel",
)
ɛ = Phoneme.create(
    symbol: "ɛ",
    place: "near-front",
    manner: "open-mid",
    category: "vowel",
)
œ = Phoneme.create(
    symbol: "œ",
    place: "central",
    manner: "open-mid",
    category: "vowel",
)
ɜ = Phoneme.create(
    symbol: "ɜ",
    place: "central",
    manner: "open-mid",
    category: "vowel",
)
ɞ = Phoneme.create(
    symbol: "ɞ",
    place: "near-back",
    manner: "open-mid",
    category: "vowel",
)
ʌ = Phoneme.create(
    symbol: "ʌ",
    place: "back",
    manner: "open-mid",
    category: "vowel",
)
ə = Phoneme.create(
    symbol: "ə",
    place: "back",
    manner: "open-mid",
    category: "vowel",
)
ɔ = Phoneme.create(
    symbol: "ɔ",
    place: "back",
    manner: "open-mid",
    category: "vowel",
)
æ = Phoneme.create(
    symbol: "æ",
    place: "near-front",
    manner: "near-open",
    category: "vowel",
)
ɐ = Phoneme.create(
    symbol: "ɐ",
    place: "near-back",
    manner: "near-open",
    category: "vowel",
)
a = Phoneme.create(
    symbol: "a",
    place: "central",
    manner: "open",
    category: "vowel",
)
ä = Phoneme.create(
    symbol: "ä",
    place: "near-back",
    manner: "open",
    category: "vowel",
)
ɑ = Phoneme.create(
    symbol: "ɑ",
    place: "back",
    manner: "open",
    category: "vowel",
)
ɒ = Phoneme.create(
    symbol: "ɒ",
    place: "back",
    manner: "open",
    category: "vowel",
)
#end basic vowels
#begin rotic vowels
ɚ = Phoneme.create(
    symbol: "ɚ",
    place: "back",
    manner: "rotic",
    category: "vowel",
)
ɔ˞ = Phoneme.create(
    symbol: "ɔ˞",
    place: "back",
    manner: "rotic",
    category: "vowel",
)
ɑ˞ = Phoneme.create(
    symbol: "ɔɑ˞",
    place: "back",
    manner: "rotic",
    category: "vowel",
)
ɝ = Phoneme.create(
    symbol: "ɝ",
    place: "mid",
    manner: "rotic",
    category: "vowel",
)

#begin dipthongs
aɪ = Phoneme.create(
    symbol: "aɪ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)
eɪ = Phoneme.create(
    symbol: "eɪ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)
oʊ = Phoneme.create(
    symbol: "oʊ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)
aʊ = Phoneme.create(
    symbol: "aʊ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)
eə = Phoneme.create(
    symbol: "eə",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)
ɪə = Phoneme.create(
    symbol: "ɪə",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)
ɔɪ = Phoneme.create(
    symbol: "ɔɪ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)
ʊə = Phoneme.create(
    symbol: "ʊə",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)
ɔʏ = Phoneme.create(
    symbol: "ɔʏ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
)

#LANGUAGES
arabic = Language.create(
    name: "Arabic", 
    hello: "اهلا", 
    speakers: "310 million",
    duolingo:"ar",
    flag: "eg",
    written_name: "ٱلْعَرَبِيَّة",
    morphology_id: agglutinative.id,
    language_family_id: semitic.id,
    orthography_id: arabic_script.id,
    noun_classes: 2,
    contrastive_diacritic: "stress-timed syllables, uses vowel length and consonant aspiration to distinguish words",
    syllable_structure:"cv",
    syllable_structure_2:"cvv",
    john: "jahja",
    mary:"marjam",
)
english = Language.create(
    name: "English", 
    hello: "Hello", 
    speakers: "1.5 billion",
    duolingo:"https://www.duolingo.com/enroll/en/es/Learn-English",
    flag: "gb",
    written_name: "English",
    morphology_id: analytic.id,
    language_family_id: germanic.id,
    orthography_id: latin.id,
    noun_classes: 0,
    contrastive_diacritic: "stressed-timed syllables",
    syllable_structure:"ccv",
    syllable_structure_2:"cv",
    john: "d͡ʒan",
    mary:"mɛri",
)

german = Language.create(
    name: "German", 
    hello: "Hallo", 
    speakers:"approx. 210 million",
    duolingo:"de",
    flag: "de",
    written_name: "Deutsch",
    morphology_id: agglutinative.id,
    language_family_id: germanic.id,
    orthography_id: latin.id,
    noun_classes: 3,
    contrastive_diacritic: "stress-timed syllables",
    syllable_structure:"cv",
    syllable_structure_2:"cvc",
    john: "hans",
    mary:"mɛri",
)
hawaiian = Language.create(
    name: "Hawaiian", 
    hello: "Aloha", 
    speakers: "approx. 30 thousand",
    duolingo: "hw",
    flag: "um",
    written_name: "ʻŌlelo Hawaiʻi",
    morphology_id: analytic.id,
    language_family_id: polynesian.id,
    orthography_id: latin.id,
    noun_classes: 2,
    contrastive_diacritic: "vowel length is used to distinguish words, and declension is used to identify the class/gender of a word",
    syllable_structure:"cvv",
    syllable_structure_2:"cv",
    john: "hone" ,
    mary:"malia",
)
japanese = Language.create(
    name: "Japanese", 
    hello: "こんにちは", 
    speakers: "128 million",
    duolingo: "ja",
    flag: "jp",
    written_name: "日本語",
    morphology_id: agglutinative.id,
    language_family_id: japonic.id,
    orthography_id: kana.id,
    noun_classes: 0,
    contrastive_diacritic: "mora-timed syllables, and uses vowel length to distinguish words",
    syllable_structure:"cv",
    syllable_structure_2:"vn",
    john: "d͡ʒon" ,
    mary: "mɜɾi",
)
#n means it would have to be an n for the consonant
korean = Language.create(
    name: "Korean", 
    hello: "안녕하세요", 
    speakers: "75 million",
    duolingo: "ko",
    flag: "kr",
    written_name: "한국어",
    morphology_id: agglutinative.id,
    language_family_id: koreanic.id,
    orthography_id: hangul.id,
    noun_classes: 0,
    contrastive_diacritic: "syllable-timed, and uses aspiration to distinguish words",
    syllable_structure:"cv",
    syllable_structure_2:"cvc",
    john: "joan",
    mary:"mɜɾi",
)
mandarin = Language.create(
    name: "Mandarin", 
    hello: "你好", 
    speakers: "1.3 billion",
    duolingo: "zh",
    flag: "cn",
    written_name: "普通话",
    morphology_id: analytic.id,
    language_family_id: sinitic.id,
    orthography_id: hanzi.id,
    noun_classes: 0,
    contrastive_diacritic: "stress-timed, and uses tone to distinguish words",
    syllable_structure:"cv",
    syllable_structure_2:"vn",
    john: "ʈ͡ʂan",
    mary:"maɾija",
)
#n means it would have to be an n for the consonant
navajo = Language.create(
    name: "Navajo", 
    hello: "Yá'át'ééh", 
    speakers: "170 thousand",
    duolingo: "nv",
    flag: "us",
    written_name: "Diné bizaad",
    morphology_id: polysynthetic.id,
    language_family_id: athabaskan.id,
    orthography_id: latin.id,
    noun_classes: 2,
    contrastive_diacritic: "uses tone, phonemic length, and aspiration to distinguish words",
    syllable_structure:"c?v",
    john: "dʒɔn",
    mary:"meɣi",
)
#? means either c or v
spanish = Language.create(
    name: "Spanish", 
    hello: "Hola", 
    speakers: "approx. 593 million",
    duolingo: "es",
    flag: "es",
    written_name: "Español",
    morphology_id: fusional.id,
    language_family_id: italic.id,
    orthography_id: latin.id,
    noun_classes: 2,
    contrastive_diacritic: "a syllable-timed language",
    syllable_structure:"cv",
    syllable_structure_2:"ccv",
    john: "hjaŋ",
    mary: "maɾija",
)
swahili = Language.create(
    name: "Swahili", 
    hello: "Hamjambo", 
    speakers: "approx. 125 million",
    duolingo: "sw",
    flag: "tz",
    written_name: "Kiswahili",
    morphology_id: agglutinative.id,
    language_family_id: benue.id,
    orthography_id: latin.id,
    noun_classes: 18,
    contrastive_diacritic: "vowels are never reduced,regardless of stress. Some dialects use aspiration to distinguish words",
    syllable_structure:"cv",
    john: "d͡ʒnɛ",
    mary:"mɑriɑ",
)

#LANGUAGE PHONEMES
LanguagePhoneme.create(language_id: english.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: b.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: d.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: g.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ʔ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ŋ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: f.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: v.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: θ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ð.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: z.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ʃ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ʒ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: t͡ʃ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: d͡ʒ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: h.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɹ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: w.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: æ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɑ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɒ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ʌ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɛ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɪ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɔ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ʊ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: u.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: oʊ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: aʊ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: aɪ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: eɪ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɔɪ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɝ.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɑ˞.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɔ˞.id)
LanguagePhoneme.create(language_id: english.id, phoneme_id: ɚ.id)
#German
LanguagePhoneme.create(language_id: german.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: b.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: d.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: g.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ʔ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: p̪͡f.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: t͡s.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: t͡ʃ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: d͡ʒ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: f.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: v.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ʃ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: z.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ʒ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ç.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: h.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: r.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ŋ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: x.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: a.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ɛ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: e.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ɪ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ɔ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: o.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: œ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ø.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ʊ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: u.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ʏ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: y.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: ɔʏ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: aɪ.id)
LanguagePhoneme.create(language_id: german.id, phoneme_id: aʊ.id)
#Japanese
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: b.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ç.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ɕ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: d.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: d͡z.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: d͡ʑ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ɸ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: g.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: h.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ɲ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ŋ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ɴ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ɾ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: t͡ɕ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: t͡s.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ɰ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: z.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ʑ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ʔ.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: a.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: e.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: o.id)
LanguagePhoneme.create(language_id: japanese.id, phoneme_id: ɯ.id)
#korean
LanguagePhoneme.create(language_id: korean.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: t͡ɕ.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: t͡s.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: ŋ.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: h.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: ɰ.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: e.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: ɛ.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: a.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: o.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: u.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: ʌ.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: ɯ.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: ø.id)
LanguagePhoneme.create(language_id: korean.id, phoneme_id: y.id)
#Hawaiian
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: h.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: v.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: w.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: ʔ.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: a.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: ɐ.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: ə.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: e.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: o.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: u.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: oʊ.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: aʊ.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: aɪ.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: eɪ.id)
LanguagePhoneme.create(language_id: hawaiian.id, phoneme_id: eə.id)
#spanish
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: b.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: β.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: d.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ð.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: f.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: g.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ɣ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ʝ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ɟʝ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ʎ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ɱ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ɲ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ŋ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: r.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ɾ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: θ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: t͡ʃ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: v.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: x.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: z.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: ʃ.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: t͡s.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: a.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: e.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: o.id)
LanguagePhoneme.create(language_id: spanish.id, phoneme_id: u.id)
#Mandarin
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: f.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ŋ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ɻ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ʂ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: t͡s.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: t͡ɕ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ɕ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ʈ͡ʂ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: w.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: x.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ɥ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: a.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ɤ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ɛ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: æ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: e.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ə.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ɚ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: o.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: u.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: ʊ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: y.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: aɪ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: aʊ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: eɪ.id)
LanguagePhoneme.create(language_id: mandarin.id, phoneme_id: oʊ.id)
#arabic
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: q.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ʔ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: b.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: d.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: g.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: f.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: θ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ʃ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: x.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: χ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ħ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: h.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: v.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ð.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: z.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ɣ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ʁ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ʕ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: r.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: d͡ʒ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: u.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: a.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ◌ˤ.id)
LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ◌ʼ.id)
#swahili
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ɲ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ŋ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: b.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ɓ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ɗ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: d.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ʄ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: d͡ʒ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ɠ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: g.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: t͡ʃ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: v.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ð.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: z.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ɣ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: f.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: θ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ʃ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: x.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: h.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: w.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: r.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ɑ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ɛ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: ɔ.id)
LanguagePhoneme.create(language_id: swahili.id, phoneme_id: u.id)
#navajo
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: p.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: t.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: t͡s.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: t͡ʃ.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: ʔ.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: tɬ.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: k.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: ɬ.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: s.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: ʃ.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: x.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: h.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: l.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: z.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: ʒ.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: ɣ.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: m.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: n.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: j.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: w.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: i.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: ɪ.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: e.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: o.id)
LanguagePhoneme.create(language_id: navajo.id, phoneme_id: ɑ.id)

#COMPARISONS

def phonemeDiff(native_language, target_language)
    nativeMeans=[]
    native_language.phonemes.map do |phoneme|
        nativeMeans << phoneme.place
        nativeMeans << phoneme.manner
    end
    uniqSounds = []
    uniqMeans = 0
    target_language.phonemes.map do |phoneme|
        if native_language.phonemes.exclude?(phoneme)
            uniqSounds << phoneme
        end
        if nativeMeans.exclude?(phoneme.place)
            uniqMeans + 2
        end
        if nativeMeans.exclude?(phoneme.manner)
            uniqMeans + 3
        end
    end

    return (uniqMeans + uniqSounds.length)/2
end

def familyDiff(lang1, lang2)
    x1 = lang1.language_family.x_coordinate 
    x2 = lang2.language_family.x_coordinate 
    y1 = lang1.language_family.y_coordinate
    y2 = lang2.language_family.y_coordinate
    distance = Math.sqrt(((x2 - x1)**2)+((y2-y1)**2))
    if distance < 20
        return distance
    else 
        return 20 + distance/75
    end
end

def nounClassDiff(lang1, lang2)
    diff = (lang1.noun_classes - lang2.noun_classes) 
    if diff > 10 || diff < -10
        return 5
    else 
        return diff 
    end
end

def morphologyDiff(lang1, lang2)
    Math.sqrt((lang1.morphology.coordinate_value- lang2.morphology.coordinate_value)**2) + nounClassDiff(lang1, lang2)
end

def orthographyDiff(lang1, lang2)
    orthValues = Math.sqrt((lang1.orthography.coordinate_value - lang2.orthography.coordinate_value)**2)
end

languages = Language.all
languages.map do |native_language|
    target_languages = Language.all - [native_language]
    target_languages.map do|target_language|
        Comparison.create(
            native_language_id: native_language.id,
            target_language_id:target_language.id,
            contrastive_value: phonemeDiff(native_language,target_language) + 
            familyDiff(native_language,target_language) + 
            orthographyDiff(native_language,target_language),
        )  
    end
end

