class CreateOrthographies < ActiveRecord::Migration[6.0]
  def change
    create_table :orthographies do |t|
      t.string :name
      t.string :system
      t.integer :coordinate_value
      t.timestamps
    end
  end
end
