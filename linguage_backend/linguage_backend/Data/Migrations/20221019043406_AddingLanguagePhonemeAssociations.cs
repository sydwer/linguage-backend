using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace linguage_backend.Migrations
{
    public partial class AddingLanguagePhonemeAssociations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
DECLARE @english INT = (SELECT l.id FROM languages l WHERE l.name = 'English');
DECLARE @german INT = (SELECT l.id FROM languages l WHERE l.name = 'German');
DECLARE @japanese INT = (SELECT l.id FROM languages l WHERE l.name = 'Japanese');
DECLARE @korean INT = (SELECT l.id FROM languages l WHERE l.name = 'Korean');
DECLARE @hawaiian INT = (SELECT l.id FROM languages l WHERE l.name = 'Hawaiian');
DECLARE @spanish INT = (SELECT l.id FROM languages l WHERE l.name = 'Spanish');
DECLARE @mandarin INT = (SELECT l.id FROM languages l WHERE l.name = 'Mandarin');
DECLARE @arabic INT = (SELECT l.id FROM languages l WHERE l.name = 'Arabic');
DECLARE @swahili INT = (SELECT l.id FROM languages l WHERE l.name = 'Swahili');
DECLARE @navajo INT = (SELECT l.id FROM languages l WHERE l.name = 'Navajo');
INSERT INTO [dbo].[language_phonemes]
           ([language_id]
           ,[phoneme_id]
           ,[created_at]
           ,[updated_at])
     VALUES
           (@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
--ENGLISH
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='b'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='d'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='g'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ŋ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='f'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='v'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'θ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ð'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='z'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʒ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'd͡ʒ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='h'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɹ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='w'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'æ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɑ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɒ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʌ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɛ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʊ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='u'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'oʊ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'aʊ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'aɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'eɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɔɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɝ'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɔɑ˞'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɔ˞'),
           GETDATE(),
		   GETDATE()
		   ),
(@english,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɚ'),
           GETDATE(),
		   GETDATE()
		   ),
--GERMAN
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='b'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='d'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='g'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'p̪͡f'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡s'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'd͡ʒ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='f'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='v'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='z'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʒ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ç'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='h'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='r'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ŋ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='x'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɛ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='e'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='o'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'œ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ø'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʊ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='u'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʏ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='y'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɔʏ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'aɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@german,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'aʊ'),
           GETDATE(),
		   GETDATE()
		   ),
--JAPANESE
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='b'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ç'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɕ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='d'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'd͡z'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'd͡ʑ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɸ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='g'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='h'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɲ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ŋ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɴ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɾ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡ɕ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡s'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɰ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='z'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʑ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='e'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='o'),
           GETDATE(),
		   GETDATE()
		   ),
(@japanese,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɯ'),
           GETDATE(),
		   GETDATE()
		   ),
--KOREAN
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡ɕ'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡s'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ŋ'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='h'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɰ'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='e'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɛ'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='o'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='u'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʌ'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɯ'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ø'),
           GETDATE(),
		   GETDATE()
		   ),
(@korean,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='y'),
           GETDATE(),
		   GETDATE()
		   ),
--HAWAIIAN
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='h'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='w'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɐ'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ə'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='e'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='o'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='u'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'oʊ'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'aʊ'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'aɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'eɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@hawaiian,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'eə'),
           GETDATE(),
		   GETDATE()
		   ),

--SPANISH
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='b'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'β'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='d'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ð'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='f'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='g'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɣ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʝ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɟʝ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʎ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɱ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɲ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ŋ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='r'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɾ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'θ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='v'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='x'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='z'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡s'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='e'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='o'),
           GETDATE(),
		   GETDATE()
		   ),
(@spanish,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='u'),
           GETDATE(),
		   GETDATE()
		   ),
--CHINESE
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='f'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ŋ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɻ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʂ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡s'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡ɕ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɕ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʈ͡ʂ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='w'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='x'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɥ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɤ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɛ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'æ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='e'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ə'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɚ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='o'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='u'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʊ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='y'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'aɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'aʊ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'eɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@mandarin,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'oʊ'),
           GETDATE(),
		   GETDATE()
		   ),
--ARABIC
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='q'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='b'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='d'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='g'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='f'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'θ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='x'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'χ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ħ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='h'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='v'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ð'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='z'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɣ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʁ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʕ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='r'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'd͡ʒ'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='u'),
           GETDATE(),
		   GETDATE()
		   ),
(@arabic,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   ),
--SWAHILI
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɲ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ŋ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='b'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɓ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɗ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='d'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʄ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'd͡ʒ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɠ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='g'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='v'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ð'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='z'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɣ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='f'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'θ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='x'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='h'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='w'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='r'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɛ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@swahili,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='u'),
           GETDATE(),
		   GETDATE()
		   ),
--NAVAJO
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='p'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='t'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡s'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N't͡ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʔ'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'tɬ'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='k'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɬ'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='s'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʃ'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='x'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='h'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='l'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='z'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ʒ'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɣ'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='m'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='n'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='j'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='w'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='i'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol =N'ɪ'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='e'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='o'),
           GETDATE(),
		   GETDATE()
		   ),
(@navajo,
		   (SELECT TOP 1 id FROM phonemes p WHERE p.symbol ='a'),
           GETDATE(),
		   GETDATE()
		   )
                ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(@"DELETE * FROM lanauage_phonemes");

        }
    }
}
