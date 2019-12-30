class CreatePhonemes < ActiveRecord::Migration[6.0]
  def change
    create_table :phonemes do |t|

      t.timestamps
    end
  end
end
