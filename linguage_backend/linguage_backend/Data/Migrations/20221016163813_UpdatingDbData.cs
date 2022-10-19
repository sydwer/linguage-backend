using linguage_backend.Data.Contexts;
using linguage_backend.Data.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.FileSystemGlobbing;
using static System.Net.WebRequestMethods;

#nullable disable

namespace linguage_backend.Migrations
{
    public partial class UpdatingDbData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ///////////////////////////////////////////
            ///
            /// Language Families 
            /// 
            ///////////////////////////////////////////
            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Germanic",
                      "Indo-European",
                       55.097230,
                       4.737163,
                       DateTime.Now,
                       DateTime.Now
                    }
                });

            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Italic",
                      "Indo-European",
                       41.164182,
                       7.288966,
                       DateTime.Now,
                       DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Koreanic",
                      "*Language-Isolate",
                       38.274575,
                       127.436801,
                       DateTime.Now,
                       DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Japanese",
                      "Japonic",
                       38.555683,
                       140.238261,
                       DateTime.Now,
                       DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Sinitic",
                      "Sino-Tibetan",
                       29.676122,
                       -253.065067,
                       DateTime.Now,
                       DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Polynesian",
                      "Austronesian",
                       19.338034,
                       -155.565148,
                       DateTime.Now,
                       DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Semitic",
                      "Afro-Asiatic",
                       26.391870,
                       34.759093,
                       DateTime.Now,
                       DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Benue-Congo",
                      "Bantu",
                       -12.052751,
                       -329.672184,
                       DateTime.Now,
                       DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "language_families",
                columns: new[] { "specific_family", "general_family", "x_coordinate", "y_coordinate", "created_at", "updated_at" },
                values: new object[,]
                {
                    { "Athabaskan",
                      "Na-Dene",
                       37.463959,
                       -477.705883,
                       DateTime.Now,
                       DateTime.Now
                    }
                });

            ///////////////////////////////////////////
            ///
            /// Morpohologies 
            /// 
            ///////////////////////////////////////////
            migrationBuilder.InsertData(
                table: "morphologies",
                columns: new[] { "name", "coordinate_value", "created_at", "updated_at", "description" },
                values: new object[,]
                {
                    {
                        "Polysynthetic",
                        5,
                        DateTime.Now,
                        DateTime.Now,
                        "A grammatical process characterized by complex words consisting of several morphemes, in which a single word may function as a whole sentence"
                    }
                }
                );
            
            migrationBuilder.InsertData(
                table: "morphologies",
                columns: new[] { "name", "coordinate_value", "created_at", "updated_at", "description" },
                values: new object[,]
                {
                    {
                        "Agglutinative",
                        4,
                        DateTime.Now,
                        DateTime.Now,
                        "A grammatical process in which words are composed of a sequence of morphemes (meaningful word elements), each of which represents not more than a single grammatical category."
                    }
                }
                );
            
            migrationBuilder.InsertData(
                table: "morphologies",
                columns: new[] { "name", "coordinate_value", "created_at", "updated_at", "description" },
                values: new object[,]
                {
                    {
                        "Fusional",
                        3,
                        DateTime.Now,
                        DateTime.Now,
                        "A grammatical process with a tendency to use a single inflectional morpheme to denote multiple grammatical, syntactic, or semantic features."
                    }
                }
                );
            
            migrationBuilder.InsertData(
                table: "morphologies",
                columns: new[] { "name", "coordinate_value", "created_at", "updated_at", "description" },
                values: new object[,]
                {
                    {
                        "Analytic",
                        0,
                        DateTime.Now,
                        DateTime.Now,
                        "A language that uses specific grammatical words, or particles, rather than inflection(changing or adding to a word), to express syntactic relations within sentences."
                    }
                }
            );

            ///////////////////////////////////////////
            ///
            /// Orthographies 
            /// 
            ///////////////////////////////////////////
            migrationBuilder.InsertData(
                table: "orthographies",
                columns: new[] { "name", "system", "coordinate_value", "created_at", "updated_at" },
                values: new object[,]
                {
                    {
                        "The Latin Alphabet",
                        "Alphabetic (every symbol represents a consonant or vowel)",
                        "1",
                        DateTime.Now,
                        DateTime.Now
                    }
                });
                
            migrationBuilder.InsertData(
                table: "orthographies",
                columns: new[] { "name", "system", "coordinate_value", "created_at", "updated_at" },
                values: new object[,]
                {
                    {
                        "Hirigana, Katakana, and Kanji",
                        "Kanji is logographic (each symbol represents a word), Kana is syllabic (each symbol represents a syllable)",
                        "3",
                        DateTime.Now,
                        DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "orthographies",
                columns: new[] { "name", "system", "coordinate_value", "created_at", "updated_at" },
                values: new object[,]
                {
                    {
                        "Arabic script",
                        "Abjad (each symbol represents a consonant, so the reader must supply the appropriate vowel)",
                        "4",
                        DateTime.Now,
                        DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "orthographies",
                columns: new[] { "name", "system", "coordinate_value", "created_at", "updated_at" },
                values: new object[,]
                {
                    {
                        "Hangul",
                        "Syllabic (each symbol represents a syllable)",
                        "2",
                        DateTime.Now,
                        DateTime.Now
                    }
                });
            
            migrationBuilder.InsertData(
                table: "orthographies",
                columns: new[] { "name", "system", "coordinate_value", "created_at", "updated_at" },
                values: new object[,]
                {
                    {
                        "Hanzi",
                        "Logographic (each symbol represents both a word and a sound)",
                        "5",
                        DateTime.Now,
                        DateTime.Now
                    }
                });

            ///////////////////////////////////////////
            ///
            /// Phonemes 
            /// 
            ///////////////////////////////////////////
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "p",
                        "bilabial",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_bilabial_plosive.mp3",
                        "p"
                    }
                });

            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "b",
                        "bilabial",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_bilabial_plosive.mp3",
                        "b"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "t",
                        "alveolar",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_plosive.mp3",
                        "t"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "d",
                        "alveolar",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_plosive.mp3",
                        "d"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʈ",
                        "retroflex",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_retroflex_plosive.mp3",
                        "t"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɖ",
                        "retroflex",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_retroflex_plosive.mp3",
                        "d"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "tɬ",
                        "alveolar",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_affricate.mp3",
                        "tcha"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "m",
                        "bilabial",
                        "nasal",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Bilabial_nasal.mp3",
                        "m"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɱ",
                        "labiodental",
                        "nasal",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Labiodental_nasal.mp3",
                        "m"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "n",
                        "alveolar",
                        "nasal",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_nasal.mp3",
                        "n"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɳ",
                        "retroflex",
                        "nasal",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Retroflex_nasal.mp3",
                        "n"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʙ",
                        "bilabial",
                        "trill",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Bilabial_trill.mp3",
                        "br"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "r",
                        "alveolar",
                        "trill",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_trill.mp3",
                        "rr"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɾ",
                        "alveolar",
                        "tap",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_tap.mp3",
                        "r"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɽ",
                        "retroflex",
                        "tap",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Retroflex_flap.mp3",
                        "r"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɸ",
                        "bilabial",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_bilabial_fricative.mp3",
                        "fh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "β",
                        "bilabial",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_bilabial_fricative.mp3",
                        "vh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "f",
                        "labiodental",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_labiodental_fricative.mp3",
                        "f"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "v",
                        "labiodental",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_labiodental_fricative.mp3",
                        "v"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "θ",
                        "dental",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_dental_fricative.mp3",
                        "th"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ð",
                        "dental",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_dental_fricative.mp3",
                        "d"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "s",
                        "alveolar",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_fricative.mp3",
                        "s"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "z",
                        "alveolar",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_fricative.mp3",
                        "z"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʃ",
                        "post-alveolar",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_postalveolar_fricative.mp3",
                        "sh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʒ",
                        "post-alveolar",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_postalveolar_fricative.mp3",
                        "j"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʂ",
                        "retroflex",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_retroflex_fricative.mp3",
                        "sh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʐ",
                        "retroflex",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_retroflex_fricative.mp3",
                        "zsh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɬ",
                        "alveolar",
                        "lateral fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_lateral_fricative.mp3",
                        "shl"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɮ",
                        "alveolar",
                        "lateral fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_lateral_fricative.mp3",
                        "ts"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʋ",
                        "labiodental",
                        "approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Labiodental_approximant.mp3",
                        "vh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɹ",
                        "alveolar",
                        "approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_approximant.mp3",
                        "r"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɻ",
                        "retroflex",
                        "approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Retroflex_approximant.mp3",
                        "r"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "l",
                        "alveolar",
                        "lateral approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_lateral_approximant.mp3",
                        "l"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɭ",
                        "retroflex",
                        "lateral approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Retroflex_lateral_approximant.mp3",
                        "l"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "c",
                        "palatal",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_palatal_plosive.mp3",
                        "ky"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɟ",
                        "palatal",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_palatal_plosive.mp3",
                        "gy"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "k",
                        "velar",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_velar_plosive.mp3",
                        "k"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "g",
                        "velar",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_velar_plosive.mp3",
                        "g"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "q",
                        "uvular",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_uvular_plosive.mp3",
                        "g"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "q",
                        "uvular",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_uvular_plosive.mp3",
                        "g"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɢ",
                        "uvular",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_uvular_plosive.mp3",
                        "g"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʔ",
                        "glottal",
                        "plosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Glottal_stop.mp3",
                        "'"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɲ",
                        "palatal",
                        "nasal",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Palatal_nasal.mp3",
                        "ny"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ŋ",
                        "velar",
                        "nasal",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Velar_nasal.mp3",
                        "n"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɴ",
                        "uvular",
                        "nasal",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Uvular_nasal.mp3",
                        "'n"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʀ",
                        "uvular",
                        "trill",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Uvular_trill.mp3",
                        "'r"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ç",
                        "palatal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_palatal_fricative.mp3",
                        "thy"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʝ",
                        "palatal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_palatal_fricative.mp3",
                        "h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "x",
                        "velar",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_velar_fricative.mp3",
                        "h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɣ",
                        "velar",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_velar_fricative.mp3",
                        "gh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "χ",
                        "uvular",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_uvular_fricative.mp3",
                        "'h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʁ",
                        "uvular",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_uvular_fricative.mp3",
                        "'gh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ħ",
                        "pharyngeal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_pharyngeal_fricative.mp3",
                        "h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʕ",
                        "pharyngeal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_pharyngeal_fricative.mp3",
                        "gh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "h",
                        "glottal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_glottal_fricative.mp3",
                        "h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɦ",
                        "glottal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_glottal_fricative.mp3",
                        "h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "j",
                        "palatal",
                        "approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Palatal_approximant.mp3",
                        "y"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɰ",
                        "velar",
                        "approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_velar_approximant.mp3",
                        "hw"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʎ",
                        "palatal",
                        "lateral approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Palatal_lateral_approximant.mp3",
                        "y"
                    }
                });

            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʟ",
                        "velar",
                        "lateral approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Velar_lateral_approximant.mp3",
                        "'l'"
                    }
                });

            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "w",
                        "labio-velar",
                        "approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_labio-velar_approximant.mp3",
                        "w"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʘ",
                        "bilabial",
                        "click",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_labio-velar_approximant.mp3",
                        "w"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ǀ",
                        "dental",
                        "click",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Dental_click.mp3",
                        "p!"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "!",
                        "alveolar",
                        "click",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_lateral_click.mp3",
                        "t!"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ǂ",
                        "palato-alveolar",
                        "click",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Palatoalveolar_click.mp3",
                        "n!"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ǁ",
                        "alveolar lateral",
                        "click",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Postalveolar_click.mp3",
                        "l!"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɓ",
                        "bilabial",
                        "implosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_bilabial_implosive.mp3",
                        "b̅"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɗ",
                        "alveolar",
                        "implosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_implosive.mp3",
                        "d̅"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʄ",
                        "palatal",
                        "implosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_palatal_implosive.mp3",
                        "j̅"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɠ",
                        "velar",
                        "implosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_velar_implosive.mp3",
                        "g̅"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʛ",
                        "uvular",
                        "implosive",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_uvular_implosive.mp3",
                        "g̅l̅"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "t͡s",
                        "alveolar",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolar_affricate.mp3",
                        "ts"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "t͡ʃ",
                        "palato-alveolar",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_palato-alveolar_affricate.mp3",
                        "ch"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "t͡ɕ",
                        "alveolo-alveolar",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolo-palatal_affricate.mp3",
                        "chy"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "t͡ɕ",
                        "retroflex",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_retroflex_affricate.mp3",
                        "tcha"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "d͡z",
                        "alveolar",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolar_affricate.mp3",
                        "dz"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "d͡ʒ",
                        "post-alveolar",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_postalveolar_affricate.mp3",
                        "j"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "d͡ʑ",
                        "alveolo-palatal",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_alveolo-palatal_affricate.mp3",
                        "j"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɖ͡ʐ",
                        "retroflex",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_retroflex_affricate.mp3",
                        "ty"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "p̪͡f",
                        "labiodental",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/8/83/Voiceless_labiodental_affricate.ogg",
                        "pf"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɟʝ",
                        "palatal",
                        "affricate",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/a/aa/Voiced_palatal_affricate.ogg",
                        "jh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɥ",
                        "labio-palatal",
                        "approximant",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Labial-palatal_approximant.mp3",
                        "h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʜ",
                        "epiglottal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_epiglottal_fricative.mp3",
                        "h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʢ",
                        "epiglottal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiced_epiglottal_fricative.mp3",
                        "h"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʡ",
                        "epiglottal",
                        null,
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_epiglottal_plosive.mp3",
                        "'hl"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɕ",
                        "alveolo-palatal",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Voiceless_alveolo-palatal_fricative.mp3",
                        "tsh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɺ",
                        "alveolar",
                        "lateral flap",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Alveolar_tap.mp3",
                        "r"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɧ",
                        "post-alveolar-velar",
                        "fricative",
                        "consonant",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/4/42/Voiceless_dorso-palatal_velar_fricative.ogg",
                        "shw"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "i",
                        "front",
                        "close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_front_unrounded_vowel.mp3",
                        "e"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "y",
                        "front",
                        "close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_front_rounded_vowel.mp3",
                        "i"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɨ",
                        "central",
                        "close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_central_unrounded_vowel.mp3",
                        "e"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʉ",
                        "central",
                        "close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_central_rounded_vowel.mp3",
                        "e-oo"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɯ",
                        "back",
                        "close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_back_unrounded_vowel.mp3",
                        "i"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "u",
                        "back",
                        "close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close_back_rounded_vowel.mp3",
                        "u"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɪ",
                        "near-front",
                        "near-close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-close_near-front_unrounded_vowel.mp3",
                        "i"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʏ",
                        "near-front",
                        "near-close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-close_near-front_rounded_vowel.mp3",
                        "i"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʊ",
                        "near-back",
                        "near-close",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-close_near-back_rounded_vowel.mp3",
                        "u"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "e",
                        "front",
                        "close-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_front_unrounded_vowel.mp3",
                        "e"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ø",
                        "front",
                        "close-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_front_rounded_vowel.mp3",
                        "e"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɘ",
                        "central",
                        "close-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_central_unrounded_vowel.mp3",
                        "u"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɵ",
                        "central",
                        "close-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_central_rounded_vowel.mp3",
                        "u"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɤ",
                        "back",
                        "close-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_back_unrounded_vowel.mp3",
                        "o"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "o",
                        "back",
                        "close-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Close-mid_back_rounded_vowel.mp3",
                        "o"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɛ",
                        "front",
                        "open-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_front_unrounded_vowel.mp3",
                        "e"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "œ",
                        "mid-front",
                        "open-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_front_rounded_vowel.mp3",
                        "ey"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɜ",
                        "central",
                        "open-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_central_unrounded_vowel.mp3",
                        "e"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɞ",
                        "near-back",
                        "open-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_central_rounded_vowel.mp3",
                        "u"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʌ",
                        "back",
                        "open-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_back_unrounded_vowel.mp3",
                        "u"
                    }
                });
                    
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ə",
                        "central",
                        "mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Mid-central_vowel.mp3",
                        "e"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɔ",
                        "back",
                        "open-mid",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open-mid_back_rounded_vowel.mp3",
                        "a"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "æ",
                        "front",
                        "near-open",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-open_front_unrounded_vowel.mp3",
                        "ae"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɐ",
                        "central",
                        "near-open",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Near-open_central_unrounded_vowel.mp3",
                        "ah"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "a",
                        "central",
                        "open",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open_front_rounded_vowel.mp3",
                        "a"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ä",
                        "near-back",
                        "open",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open_front_unrounded_vowel.mp3",
                        "uh"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɑ",
                        "back",
                        "open",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open_back_unrounded_vowel.mp3",
                        "a"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɒ",
                        "back",
                        "open",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "http://www.internationalphoneticalphabet.org/ipa-chart-audio/mp3/Open_back_rounded_vowel.mp3",
                        "ao"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɚ",
                        "back",
                        "rotic",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/e/e1/En-us-er.ogg",
                        "er"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɔ˞",
                        "back",
                        "rotic",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/d/d0/PR-open-mid_back_rounded_vowel.ogg",
                        "ar"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɔɑ˞",
                        "back",
                        "rotic",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/e/e1/En-us-er.ogg",
                        "ar"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɝ",
                        "mid",
                        "rotic",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/e/e1/En-us-er.ogg",
                        "er"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "aɪ",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "ai"
                    }
                });

            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "eɪ",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "ei"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "oʊ",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "ou"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "aʊ",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "ow"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "eə",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "ai"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɪə",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "ea"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɔɪ",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "oi"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ʊə",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "oi"
                    }
                });
            
            migrationBuilder.InsertData(
                table: "phonemes",
                columns: new[] { "symbol", "place", "manner", "category", "created_at", "updated_at", "sound_url", "latin" },
                values: new object[,]
                {
                    {
                        "ɔʏ",
                        "variant",
                        "dipthong",
                        "vowel",
                        DateTime.Now,
                        DateTime.Now,
                        "https://upload.wikimedia.org/wikipedia/commons/1/17/En-us-no_highway_cowboys.ogg",
                        "oi"
                    }
                });

            ///////////////////////////////////////////
            ///
            /// Languages 
            /// 
            ///////////////////////////////////////////
            migrationBuilder.Sql(@"USE [linguage-backend]
GO

INSERT INTO [dbo].[languages]
           ([name]
           ,[written_name]
           ,[hello]
           ,[speakers]
           ,[flag]
           ,[duolingo]
           ,[contrastive_diacritic]
           ,[syllable_structure]
           ,[syllable_structure_2]
           ,[mary]
           ,[john]
           ,[morphology_id]
           ,[language_family_id]
           ,[orthography_id]
           ,[noun_classes]
           ,[created_at]
           ,[updated_at])
     VALUES
           ('Arabic',
           N'ٱلْعَرَبِيَّة',
           N'اهلا',
		   '310 million',
		   'eg',
		   'ar',
           'Stress-timed syllables, uses vowel length and consonant aspiration to distinguish words',
		   'cv',
		   'cvl',
		   'marjam',
		   'jahja',
		   (SELECT TOP 1 m.Id FROM dbo.morphologies m WHERE m.name = 'Agglutinative'),
		   (SELECT TOP 1 lf.Id FROM language_families lf WHERE lf.specific_family = 'Semitic'),
		   (SELECT TOP 1 o.Id FROM orthographies o WHERE o.name = 'Arabic script'),
		   2,
		   GETDATE(),
		   GETDATE()
		   ), 
           ('English',
           'English',
           'hello',
		   '1.5 billion',
		   'gb',
		   'https://www.duolingo.com/enroll/en/es/Learn-English',
           'Stressed-timed syllables',
		   'cv',
		   'ccv',
		   N'mɛri',
		   N'd͡ʒan',
		   (SELECT TOP 1 m.Id FROM dbo.morphologies m WHERE m.name = 'Analytic'),
		   (SELECT TOP 1 lf.Id FROM language_families lf WHERE lf.specific_family = 'Germanic'),
		   (SELECT TOP 1 o.Id FROM orthographies o WHERE o.name = 'The Latin Alphabet'),
		   0,
		   GETDATE(),
		   GETDATE()
		   ),
           ('German',
           'Deutsch',
           'Hallo',
		   'approx. 210 million""',
		   'de',
		   'de',
           'Stress-timed syllables, strict placement of verbs within sentances',
		   'cv',
		   'cvc',
		   N'mɛri',
		   'hans',
		   (SELECT TOP 1 m.Id FROM dbo.morphologies m WHERE m.name = 'agglutinative'),
		   (SELECT TOP 1 lf.Id FROM language_families lf WHERE lf.specific_family = 'Germanic'),
		   (SELECT TOP 1 o.Id FROM orthographies o WHERE o.name = 'The Latin Alphabet'),
		   3,
		   GETDATE(),
		   GETDATE()
		   ),
           ('Hawaiian',
           N'ʻŌlelo Hawaiʻi',
           'Aloha',
		   'approx. 30 thousand',
		   'um',
		   'hw',
           'Vowel length is used to distinguish words, and declension is used to identify the class/gender of a word',
		   'cvv',
		   'cv',
		   'malia',
		   'hone',
		   (SELECT TOP 1 Id FROM dbo.morphologies m WHERE m.name = 'analytic'),
		   (SELECT TOP 1 Id FROM language_families lf WHERE lf.specific_family = 'polynesian'),
		   (SELECT TOP 1 Id FROM orthographies o WHERE o.name = 'The Latin Alphabet'),
           2,
		   GETDATE(),
		   GETDATE()
		   ),
           ('Japanese',
           N'日本語',
           N'こんにちは',
		   '128 million',
		   'jp',
		   'ja',
           'Mora-timed syllables, and uses vowel length to distinguish words',
		   'cv',
		   'vn',
		   N'mɜɾi',
		   N'd͡ʒon',
		   (SELECT TOP 1 Id FROM dbo.morphologies m WHERE m.name = 'agglutinative'),
		   (SELECT TOP 1 Id FROM language_families lf WHERE lf.specific_family = 'Japanese'),
		   (SELECT TOP 1 Id FROM orthographies o WHERE o.name = 'Hirigana, Katakana, and Kanji'),
		   0,
		   GETDATE(),
		   GETDATE()
		   ),
           ('Korean',
           N'한국어',
           N'안녕하세요',
		   '75 million',
		   'kr',
		   'ko',
           'Syllable-timed, and uses aspiration to distinguish words',
		   'cv',
		   'cvc',
		   N'mɜɾi',
		   'joan',
		   (SELECT TOP 1 Id FROM dbo.morphologies m WHERE m.name = 'agglutinative'),
		   (SELECT TOP 1 Id FROM language_families lf WHERE lf.specific_family = 'koreanic'),
		   (SELECT TOP 1 Id FROM orthographies o WHERE o.name = 'hangul'),
		   0,
		   GETDATE(),
		   GETDATE()
		   ),
           ('Mandarin',
           N'普通话',
           N'你好',
		   '1.3 billion',
		   'cn',
		   'zh',
           'Stress-timed, and uses tone to distinguish words',
		   'cv',
		   'vn',
		   N'maɾija',
		   N'ʈ͡ʂan',
		   (SELECT TOP 1 Id FROM dbo.morphologies m WHERE m.name = 'analytic'),
		   (SELECT TOP 1 Id FROM language_families lf WHERE lf.specific_family = 'sinitic'),
		   (SELECT TOP 1 Id FROM orthographies o WHERE o.name = 'hanzi'),
		   0,
		   GETDATE(),
		   GETDATE()
		   ),
           ('Navajo',
           N'Diné bizaad',
           N'Yá''át''ééh',
		   '170 thousand',
		   'us',
		   'nv',
           'Uses tone, phonemic length, and aspiration to distinguish words',
		   'c?v',
		   null,
		   N'meɣi',
		   N'dʒɔn',
		   (SELECT TOP 1 Id FROM dbo.morphologies m WHERE m.name = 'polysynthetic'),
		   (SELECT TOP 1 Id FROM language_families lf WHERE lf.specific_family = 'athabaskan'),
		   (SELECT TOP 1 Id FROM orthographies o WHERE o.name = 'The Latin Alphabet'),
		   2,
		   GETDATE(),
		   GETDATE()
		   ),
           ('Spanish',
           N'Español',
           'Hola',
		   'approx. 593 million',
		   'es',
		   'es',
           'A syllable-timed language',
		   'cv',
		   'ccv',
		   N'maɾija',
		   N'hjaŋ',
		   (SELECT TOP 1 Id FROM dbo.morphologies m WHERE m.name = 'fusional'),
		   (SELECT TOP 1 Id FROM language_families lf WHERE lf.specific_family = 'italic'),
		   (SELECT TOP 1 Id FROM orthographies o WHERE o.name = 'The Latin Alphabet'),
		   2,
		   GETDATE(),
		   GETDATE()
		   ),
           ('Swahili',
           'Kiswahili',
           'Hamjambo',
		   'approx. 125 million',
		   'tz',
		   'sw',
           'Vowels are never reduced,regardless of stress. Some dialects use aspiration to distinguish words',
		   'cv',
		   null,
		   N'mɑriɑ',
		   N'd͡ʒnɛ',
		   (SELECT TOP 1 Id FROM dbo.morphologies m WHERE m.name = 'agglutinative'),
		   (SELECT TOP 1 Id FROM language_families lf WHERE lf.specific_family = 'Benue-Congo'),
		   (SELECT TOP 1 Id FROM orthographies o WHERE o.name = 'The Latin Alphabet'),
		   18,
		   GETDATE(),
		   GETDATE()
		   )
           
GO
 ");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE * FROM language_families;");
            migrationBuilder.Sql(@"DELETE * FROM morphologies;");
            migrationBuilder.Sql(@"DELETE * FROM orthographies;");
            migrationBuilder.Sql(@"DELETE * FROM phonemes;");
            migrationBuilder.Sql(@"DELETE * FROM languages;");
        }
    }
}
