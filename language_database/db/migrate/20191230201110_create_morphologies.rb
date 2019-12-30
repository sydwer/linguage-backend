class CreateMorphologies < ActiveRecord::Migration[6.0]
  def change
    create_table :morphologies do |t|
      t.string :name
      t.integer :coordinate_value
      t.timestamps
    end
  end
end
