class AddDescriptionToMorphologies < ActiveRecord::Migration[6.0]
  def change
    add_column :morphologies, :description, :string
  end
end
