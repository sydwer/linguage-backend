class AddLatinToPhonemes < ActiveRecord::Migration[6.0]
  def change
    add_column :phonemes, :latin, :string
  end
end
