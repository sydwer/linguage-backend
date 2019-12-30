class CreateLanguages < ActiveRecord::Migration[6.0]
  def change
    create_table :languages do |t|
      t.string :name
      t.string :written_name
      t.string :hello
      t.string :speakers
      t.string :flag 
      t.string :duolingo
      t.string :contrastive_diacritic
      t.string :syllable_structure
      t.string :syllable_structure_2
      t.string :mary
      t.string :john
      t.integer :morphology_id
      t.integer :language_family_id
      t.integer :orthography_id
      t.integer :noun_classes
      t.timestamps
    end
  end
end
