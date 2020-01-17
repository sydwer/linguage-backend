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
polysynthetic = Morphology.create(
    name: "Polysynthetic", 
    coordinate_value: 5,
    description: "A grammatical process characterized by complex words consisting of several morphemes, in which a single word may function as a whole sentence")
agglutinative = Morphology.create(
    name: "Agglutinative", 
    coordinate_value: 4,
    description: "A grammatical process in which words are composed of a sequence of morphemes (meaningful word elements), each of which represents not more than a single grammatical category.")
fusional = Morphology.create(
    name: "Fusional", 
    coordinate_value: 3,
    description: "A grammatical process with a tendency to use a single inflectional morpheme to denote multiple grammatical, syntactic, or semantic features.")
analytic = Morphology.create(
    name: "Analytic", 
    coordinate_value: 0,
    description: "A language that uses specific grammatical words, or particles, rather than inflection(changing or adding to a word), to express syntactic relations within sentences.")

#ORTHOGRAPHIES
latin = Orthography.create(
    name:"The Latin Alphabet",
    system:"Alphabetic (every symbol represents a consonant or vowel)",
    coordinate_value: 1,
)

kana = Orthography.create(
    name:"Hirigana, Katakana, and Kanji",
    system:"Kanji is logographic (each symbol represents a word), Kana is syllabic (each symbol represents a syllable)",
    coordinate_value: 3,
)
arabic_script = Orthography.create(
    name:"Arabic script",
    system:"Abjad (each symbol represents a consonant, so the reader must supply the appropriate vowel)",
    coordinate_value: 4,
)

hangul = Orthography.create(
    name:"Hangul",
    system:"Syllabic (each symbol represents a syllable)",
    coordinate_value: 2,
)
hanzi = Orthography.create(
    name:"Hanzi",
    system:"Logographic (each symbol represents both a word and a sound)",
    coordinate_value: 5,
)


#PHONEMES

p = Phoneme.create(
    symbol: "p",
    place: "bilabial",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_bilabial_plosive.mp3",
    latin: "p",
)
b = Phoneme.create(
    symbol: "b",
    place: "bilabial",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_bilabial_plosive.mp3",
    latin: "b",
)
t = Phoneme.create(
    symbol: "t",
    place: "alveolar",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_plosive.mp3",
    latin: "t",
)
d = Phoneme.create(
    symbol: "d",
    place: "alveolar",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_plosive.mp3",
    latin: "d", 
)
ʈ = Phoneme.create(
    symbol: "ʈ",
    place: "retroflex",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_retroflex_plosive.mp3",
    latin: "t",
)
ɖ = Phoneme.create(
    symbol: "ɖ",
    place: "retroflex",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_retroflex_plosive.mp3",
    latin: "d",  
)
tɬ = Phoneme.create(
    symbol: "tɬ",
    place: "alveolar",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_affricate.mp3",
    latin: "tcha",  
)
m = Phoneme.create(
    symbol: "m",
    place: "bilabial",
    manner: "nasal",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Bilabial_nasal.mp3",
    latin: "m",  
)
ɱ = Phoneme.create(
    symbol: "ɱ",
    place: "labiodental",
    manner: "nasal",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Labiodental_nasal.mp3",
    latin: "m",   
)
n = Phoneme.create(
    symbol: "n",
    place: "alveolar",
    manner: "nasal",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_nasal.mp3",
    latin: "n",  
)
ɳ = Phoneme.create(
    symbol: "ɳ",
    place: "retroflex",
    manner: "nasal",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Retroflex_nasal.mp3",
    latin: "n",  
)
ʙ = Phoneme.create(
    symbol: "ʙ",
    place: "bilabial",
    manner: "trill",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Bilabial_trill.mp3",
    latin: "br",    
)
r = Phoneme.create(
    symbol: "r",
    place: "alveolar",
    manner: "trill",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_trill.mp3",
    latin: "rr",      
)
ɾ = Phoneme.create(
    symbol: "ɾ",
    place: "alveolar",
    manner: "tap",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_tap.mp3",
    latin: "r",  
)
ɽ = Phoneme.create(
    symbol: "ɽ",
    place: "retroflex",
    manner: "tap",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Retroflex_flap.mp3",
    latin: "r",   
)
ɸ = Phoneme.create(
    symbol: "ɸ",
    place: "bilabial",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_bilabial_fricative.mp3",
    latin: "fh",   
)
β = Phoneme.create(
    symbol: "β",
    place: "bilabial",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_bilabial_fricative.mp3",
    latin: "vh",  
)
f = Phoneme.create(
    symbol: "f",
    place: "labiodental",
    manner: "fricative",
    category: "consonant",
    sound_url:"http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_labiodental_fricative.mp3",
    latin: "f",  
)
v = Phoneme.create(
    symbol: "v",
    place: "labiodental",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_labiodental_fricative.mp3",
    latin: "v",  
)
θ = Phoneme.create(
    symbol: "θ",
    place: "dental",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_dental_fricative.mp3",
    latin: "th",  
)
ð = Phoneme.create(
    symbol: "ð",
    place: "dental",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_dental_fricative.mp3",
    latin: "d",  
)
s = Phoneme.create(
    symbol: "s",
    place: "alveolar",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_fricative.mp3",
    latin: "s",  
)
z = Phoneme.create(
    symbol: "z",
    place: "alveolar",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_fricative.mp3",
    latin: "z",  
)
ʃ = Phoneme.create(
    symbol: "ʃ",
    place: "post-alveolar",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_postalveolar_fricative.mp3",
    latin: "sh",  
)
ʒ = Phoneme.create(
    symbol: "ʒ",
    place: "post-alveolar",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_postalveolar_fricative.mp3",
    latin: "j",  
)
ʂ = Phoneme.create(
    symbol: "ʂ",
    place: "retroflex",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_retroflex_fricative.mp3",
    latin: "sh",  

)
ʐ = Phoneme.create(
    symbol: "ʐ",
    place: "retroflex",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_retroflex_fricative.mp3",
    latin: "zsh",  

)
ɬ = Phoneme.create(
    symbol: "ɬ",
    place: "alveolar",
    manner: "lateral fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_lateral_fricative.mp3",
    latin: "shl",  
)
ɮ = Phoneme.create(
    symbol: "ɮ",
    place: "alveolar",
    manner: "lateral fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_lateral_fricative.mp3",
    latin: "ts",  
)
ʋ = Phoneme.create(
    symbol: "ʋ",
    place: "labiodental",
    manner: "approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Labiodental_approximant.mp3",
    latin: "vh",  
)
ɹ = Phoneme.create(
    symbol: "ɹ",
    place: "alveolar",
    manner: "approximant",
    category: "consonant",
    sound_url:"http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_approximant.mp3",
    latin: "r",  
)
ɻ = Phoneme.create(
    symbol: "ɻ",
    place: "retroflex",
    manner: "approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Retroflex_approximant.mp3",
    latin: "r",  
)
l = Phoneme.create(
    symbol: "l",
    place: "alveolar",
    manner: "lateral approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_lateral_approximant.mp3",
    latin: "l",  
)
ɭ = Phoneme.create(
    symbol: "ɭ",
    place: "retroflex",
    manner: "lateral approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Retroflex_lateral_approximant.mp3",
    latin: "l",  
)
c = Phoneme.create(
    symbol: "c",
    place: "palatal",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_palatal_plosive.mp3",
    latin: "ky",  
)
ɟ = Phoneme.create(
    symbol: "ɟ",
    place: "palatal",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_palatal_plosive.mp3",
    latin: "gy",  
)
k = Phoneme.create(
    symbol: "k",
    place: "velar",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_velar_plosive.mp3",
    latin: "k",  
)
g = Phoneme.create(
    symbol: "g",
    place: "velar",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_velar_plosive.mp3",
    latin: "g",  
)
q = Phoneme.create(
    symbol: "q",
    place: "uvular",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_uvular_plosive.mp3",
    latin: "g",  
)
ɢ = Phoneme.create(
    symbol: "ɢ",
    place: "uvular",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_uvular_plosive.mp3",
    latin: "g",  
)
ʔ = Phoneme.create(
    symbol: "ʔ",
    place: "glottal",
    manner: "plosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Glottal_stop.mp3",
    latin: "'",  
)
ɲ = Phoneme.create(
    symbol: "ɲ",
    place: "palatal",
    manner: "nasal",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Palatal_nasal.mp3",
    latin: "ny",  
)
ŋ = Phoneme.create(
    symbol: "ŋ",
    place: "velar",
    manner: "nasal",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Velar_nasal.mp3",
    latin: "n",  
)
ɴ = Phoneme.create(
    symbol: "ɴ",
    place: "uvular",
    manner: "nasal",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Uvular_nasal.mp3",
    latin: "'n",  
)
ʀ = Phoneme.create(
    symbol: "ʀ",
    place: "uvular",
    manner: "trill",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Uvular_trill.mp3",
    latin: "'r",  
)
ç = Phoneme.create(
    symbol: "ç",
    place: "palatal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_palatal_fricative.mp3",
    latin: "thy",  
)
ʝ = Phoneme.create(
    symbol: "ʝ",
    place: "palatal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_palatal_fricative.mp3",
    latin: "h",  
)
x = Phoneme.create(
    symbol: "x",
    place: "velar",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_velar_fricative.mp3",
    latin: "h",  
)
ɣ = Phoneme.create(
    symbol: "ɣ",
    place: "velar",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_velar_fricative.mp3",
    latin: "gh",  
)
χ = Phoneme.create(
    symbol: "χ",
    place: "uvular",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_uvular_fricative.mp3",
    latin: "'h",  
)
ʁ = Phoneme.create(
    symbol: "ʁ",
    place: "uvular",
    manner: "fricative",
    category: "consonant",
    sound_url:"http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_uvular_fricative.mp3",
    latin: "'gh",  
)
ħ = Phoneme.create(
    symbol: "ħ",
    place: "pharyngeal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_pharyngeal_fricative.mp3",
    latin: "h'",  
)
ʕ = Phoneme.create(
    symbol: "ʕ",
    place: "pharyngeal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_pharyngeal_fricative.mp3",
    latin: "gh'",  
)
h = Phoneme.create(
    symbol: "h",
    place: "glottal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_glottal_fricative.mp3",
    latin: "h'",  
)
ɦ = Phoneme.create(
    symbol: "ɦ",
    place: "glottal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_glottal_fricative.mp3",
    latin: "h'",  
)
j = Phoneme.create(
    symbol: "j",
    place: "palatal",
    manner: "approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Palatal_approximant.mp3",
    latin: "y",  
)
ɰ = Phoneme.create(
    symbol: "ɰ",
    place: "velar",
    manner: "approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_velar_approximant.mp3",
    latin: "hw",  
)
ʎ = Phoneme.create(
    symbol: "ʎ",
    place: "palatal",
    manner: "lateral approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Palatal_lateral_approximant.mp3",
    latin: "y",  
)
ʟ = Phoneme.create(
    symbol: "ʟ",
    place: "velar",
    manner: "lateral approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Velar_lateral_approximant.mp3",
    latin: "'l'",  
)
w = Phoneme.create(
    symbol: "w",
    place: "labio-velar",
    manner: "approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_labio-velar_approximant.mp3",
    latin: "w",  
)
#end pulmonic consts
ʘ = Phoneme.create(
    symbol: "ʘ",
    place: "bilabial",
    manner: "click",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Bilabial_click.mp3",
    latin: "!",  
)
ǀ = Phoneme.create(
    symbol: "ǀ",
    place: "dental",
    manner: "click",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Dental_click.mp3",
    latin: "p!",
)
bang = Phoneme.create(
    symbol: "!",
    place: "alveolar",
    manner: "click",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_lateral_click.mp3",
    latin: "t!",
)
ǂ = Phoneme.create(
    symbol: "ǂ",
    place: "palato-alveolar",
    manner: "click",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Palatoalveolar_click.mp3",
    latin: "n!",
)
ǁ = Phoneme.create(
    symbol: "ǁ",
    place: "alveolar lateral",
    manner: "click",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Postalveolar_click.mp3",
    latin: "l!",
)
ɓ = Phoneme.create(
    symbol: "ɓ",
    place: "bilabial",
    manner: "implosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_bilabial_implosive.mp3",
    latin: "b̅",
)
ɗ = Phoneme.create(
    symbol: "ɗ",
    place: "alveolar",
    manner: "implosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_implosive.mp3",
    latin: "d̅",
)
ʄ = Phoneme.create(
    symbol: "ʄ",
    place: "palatal",
    manner: "implosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_palatal_implosive.mp3",
    latin: "j̅",
)
ɠ = Phoneme.create(
    symbol: "ɠ",
    place: "velar",
    manner: "implosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_velar_implosive.mp3",
    latin: "g̅",
)
ʛ = Phoneme.create(
    symbol: "ʛ",
    place: "uvular",
    manner: "implosive",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_uvular_implosive.mp3",
    latin: "g̅l̅",
)

#end non-pulmonic
#start affricates
t͡s = Phoneme.create(
    symbol: "t͡s",
    place: "alveolar",
    manner: "affricate",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_affricate.mp3",
    latin: "ts",
)
t͡ʃ = Phoneme.create(
    symbol: "t͡ʃ",
    place: "palato-alveolar",
    manner: "affricate",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_palato-alveolar_affricate.mp3",
    latin: "ch",  
)
t͡ɕ = Phoneme.create(
    symbol: "t͡ɕ",
    place: "alveolo-palatal",
    manner: "affricate",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolo-palatal_affricate.mp3",
    latin: "chy",
)
ʈ͡ʂ = Phoneme.create(
    symbol: "ʈ͡ʂ",
    place: "retroflex",
    manner: "affricate",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_retroflex_affricate.mp3",
    latin: "tcha",
)
d͡z = Phoneme.create(
    symbol: "d͡z",
    place: "alveolar",
    manner: "affricate",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_affricate.mp3",
    latin: "dz",
)
d͡ʒ = Phoneme.create(
    symbol: "d͡ʒ",
    place: "post-alveolar",
    manner: "affricate",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_postalveolar_affricate.mp3",
    latin: "j",
)
d͡ʑ = Phoneme.create(
    symbol: "d͡ʑ",
    place: "alveolo-palatal",
    manner: "affricate",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolo-palatal_affricate.mp3",
    latin: "j",
)
ɖ͡ʐ = Phoneme.create(
    symbol: "ɖ͡ʐ",
    place: "retroflex",
    manner: "affricate",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_retroflex_affricate.mp3",
    latin: "ty",
)
p̪͡f = Phoneme.create(
    symbol: "p̪͡f",
    place: "labiodental",
    manner: "affricate",
    category: "consonant",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/8/83/Voiceless_labiodental_affricate.ogg",
    latin: "pf",
)
ɟʝ = Phoneme.create(
    symbol: "ɟʝ",
    place: "palatal",
    manner: "affricate",
    category: "consonant",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/a/aa/Voiced_palatal_affricate.ogg",
    latin: "jh",
)

#end affricates
#begin "other"
ɥ = Phoneme.create(
    symbol: "ɥ",
    place: "labio-palatal",
    manner: "approximant",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Labial-palatal_approximant.mp3",
    latin: "h",
)
ʜ = Phoneme.create(
    symbol: "ʜ",
    place: "epiglottal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_epiglottal_fricative.mp3",
    latin: "h",
)
ʢ = Phoneme.create(
    symbol: "ʢ",
    place: "epiglottal",
    manner: "fricative",
    category: "consonant",
    sound_url:"http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_epiglottal_fricative.mp3",
    latin: "h",
)
ʡ = Phoneme.create(
    symbol: "ʡ",
    place: "epiglottal",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_epiglottal_plosive.mp3",
    latin: "'hl",
)
ɕ = Phoneme.create(
    symbol: "ɕ",
    place: "alveolo-palatal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolo-palatal_fricative.mp3",
    latin: "tsh",
)
ʑ = Phoneme.create(
    symbol: "ʑ",
    place: "alveolo-palatal",
    manner: "fricative",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolo-palatal_fricative.mp3",
    latin: "zcha",
)
ɺ = Phoneme.create(
    symbol: "ɺ",
    place: "alveolar",
    manner: "lateral flap",
    category: "consonant",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_tap.mp3",
    latin: "r",
)
ɧ = Phoneme.create(
    symbol: "ɧ",
    place: "post-alveolar-velar",
    manner: "fricative",
    category: "consonant",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/4/42/Voiceless_dorso-palatal_velar_fricative.ogg",
    latin: "shw",
)
#end "other"
# begin basic vowels
i = Phoneme.create(
    symbol: "i",
    place: "front",
    manner: "close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_front_unrounded_vowel.mp3",
    latin: "e",
)
y = Phoneme.create(
    symbol: "y",
    place: "front",
    manner: "close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_front_rounded_vowel.mp3",
    latin: "i",
)
ɨ = Phoneme.create(
    symbol: "ɨ",
    place: "central",
    manner: "close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_central_unrounded_vowel.mp3",
    latin: "e",
)
ʉ = Phoneme.create(
    symbol: "ʉ",
    place: "central",
    manner: "close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_central_rounded_vowel.mp3",
    latin: "e-oo",
)
ɯ = Phoneme.create(
    symbol: "ɯ",
    place: "back",
    manner: "close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_back_unrounded_vowel.mp3",
    latin: "i",
)
u = Phoneme.create(
    symbol: "u",
    place: "back",
    manner: "close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_back_rounded_vowel.mp3",
    latin: "u",
)
ɪ = Phoneme.create(
    symbol: "ɪ",
    place: "near-front",
    manner: "near-close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-close_near-front_unrounded_vowel.mp3",
    latin: "i",
)
ʏ = Phoneme.create(
    symbol: "ʏ",
    place: "near-front",
    manner: "near-close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-close_near-front_rounded_vowel.mp3",
    latin: "i",
)
ʊ = Phoneme.create(
    symbol: "ʊ",
    place: "near-back",
    manner: "near-close",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-close_near-back_rounded_vowel.mp3",
    latin: "u",
)
e = Phoneme.create(
    symbol: "e",
    place: "front",
    manner: "close-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_front_unrounded_vowel.mp3",
    latin: "e",
)
ø = Phoneme.create(
    symbol: "ø",
    place: "front",
    manner: "close-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_front_rounded_vowel.mp3",
    latin: "e",
)
ɘ = Phoneme.create(
    symbol: "ɘ",
    place: "central",
    manner: "close-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_central_unrounded_vowel.mp3",
    latin: "u",
)
ɵ = Phoneme.create(
    symbol: "ɵ",
    place: "central",
    manner: "close-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_central_rounded_vowel.mp3",
    latin: "u",
)
ɤ = Phoneme.create(
    symbol: "ɤ",
    place: "back",
    manner: "close-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_back_unrounded_vowel.mp3",
    latin: "o",
)
o = Phoneme.create(
    symbol: "o",
    place: "back",
    manner: "close-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_back_rounded_vowel.mp3",
    latin: "o",
)
ɛ = Phoneme.create(
    symbol: "ɛ",
    place: "front",
    manner: "open-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_front_unrounded_vowel.mp3",
    latin: "e",
)
œ = Phoneme.create(
    symbol: "œ",
    place: "mid-front",
    manner: "open-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_front_rounded_vowel.mp3",
    latin: "ey",
)
ɜ = Phoneme.create(
    symbol: "ɜ",
    place: "central",
    manner: "open-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_central_unrounded_vowel.mp3",
    latin: "e",
)
ɞ = Phoneme.create(
    symbol: "ɞ",
    place: "near-back",
    manner: "open-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_central_rounded_vowel.mp3",
    latin: "u",
)
ʌ = Phoneme.create(
    symbol: "ʌ",
    place: "back",
    manner: "open-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_back_unrounded_vowel.mp3",
    latin: "u",
)
ə = Phoneme.create(
    symbol: "ə",
    place: "central",
    manner: "mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Mid-central_vowel.mp3",
    latin: "e",

)
ɔ = Phoneme.create(
    symbol: "ɔ",
    place: "back",
    manner: "open-mid",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_back_rounded_vowel.mp3",
    latin: "a",
)
æ = Phoneme.create(
    symbol: "æ",
    place: "front",
    manner: "near-open",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-open_front_unrounded_vowel.mp3",
    latin: "ae",
)
ɐ = Phoneme.create(
    symbol: "ɐ",
    place: "central",
    manner: "near-open",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-open_central_unrounded_vowel.mp3",
    latin: "ah",
)
a = Phoneme.create(
    symbol: "a",
    place: "central",
    manner: "open",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open_front_rounded_vowel.mp3",
    latin: "a",
)
ä = Phoneme.create(
    symbol: "ä",
    place: "near-back",
    manner: "open",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open_front_unrounded_vowel.mp3",
    latin: "uh", 
)
ɑ = Phoneme.create(
    symbol: "ɑ",
    place: "back",
    manner: "open",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open_back_unrounded_vowel.mp3",
    latin: "a",
)
ɒ = Phoneme.create(
    symbol: "ɒ",
    place: "back",
    manner: "open",
    category: "vowel",
    sound_url: "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open_back_rounded_vowel.mp3",
    latin: "ao",
)
#end basic vowels
#begin rotic vowels
ɚ = Phoneme.create(
    symbol: "ɚ",
    place: "back",
    manner: "rotic",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/e/e1/En-us-er.ogg",
    latin: "er",
)
ɔ˞ = Phoneme.create(
    symbol: "ɔ˞",
    place: "back",
    manner: "rotic",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/d/d0/PR-open-mid_back_rounded_vowel.ogg",
    latin: "ar",
)
ɑ˞ = Phoneme.create(
    symbol: "ɔɑ˞",
    place: "back",
    manner: "rotic",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/e/e1/En-us-er.ogg",
    latin: "ar",
)
ɝ = Phoneme.create(
    symbol: "ɝ",
    place: "mid",
    manner: "rotic",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/e/e1/En-us-er.ogg",
    latin: "er",
)

#begin dipthongs
aɪ = Phoneme.create(
    symbol: "aɪ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "ai",
)
eɪ = Phoneme.create(
    symbol: "eɪ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "ei",
)
oʊ = Phoneme.create(
    symbol: "oʊ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "ou",
)
aʊ = Phoneme.create(
    symbol: "aʊ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "ow",
)
eə = Phoneme.create(
    symbol: "eə",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "ai",
)
ɪə = Phoneme.create(
    symbol: "ɪə",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "ea",
)
ɔɪ = Phoneme.create(
    symbol: "ɔɪ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "oi",
)
ʊə = Phoneme.create(
    symbol: "ʊə",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "oi",
)
ɔʏ = Phoneme.create(
    symbol: "ɔʏ",
    place: "variant",
    manner: "dipthong",
    category: "vowel",
    sound_url: "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
    latin: "oi"
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
    contrastive_diacritic: "Stress-timed syllables, uses vowel length and consonant aspiration to distinguish words",
    syllable_structure:"cv",
    syllable_structure_2:"cvl",
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
    contrastive_diacritic: "Stressed-timed syllables",
    syllable_structure:"cv",
    syllable_structure_2:"ccv",
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
    contrastive_diacritic: "Stress-timed syllables, strict placement of verbs within sentances",
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
    contrastive_diacritic: "Vowel length is used to distinguish words, and declension is used to identify the class/gender of a word",
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
    contrastive_diacritic: "Mora-timed syllables, and uses vowel length to distinguish words",
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
    contrastive_diacritic: "Syllable-timed, and uses aspiration to distinguish words",
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
    contrastive_diacritic: "Stress-timed, and uses tone to distinguish words",
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
    contrastive_diacritic: "Uses tone, phonemic length, and aspiration to distinguish words",
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
    contrastive_diacritic: "A syllable-timed language",
    syllable_structure:"cv",
    # syllable_structure_2:"ccv",
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
    contrastive_diacritic: "Vowels are never reduced,regardless of stress. Some dialects use aspiration to distinguish words",
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
# LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ◌ˤ.id)
# LanguagePhoneme.create(language_id: arabic.id, phoneme_id: ◌ʼ.id)
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

