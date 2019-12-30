class CreatePhonemes < ActiveRecord::Migration[6.0]
  def change
    create_table :phonemes do |t|
      t.string :symbol
      t.string :place
      t.string :manner
      t.string :category
      t.timestamps
    end
  end
end
