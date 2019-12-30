class CreateLanguagePhonemes < ActiveRecord::Migration[6.0]
  def change
    create_table :language_phonemes do |t|
      t.references :language, foreign_key: true
      t.references :phoneme,foreign_key: true
      t.timestamps
    end
  end
end
