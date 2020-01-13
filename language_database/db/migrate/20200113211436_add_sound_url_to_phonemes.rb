class AddSoundUrlToPhonemes < ActiveRecord::Migration[6.0]
  def change
    add_column :phonemes, :sound_url, :string
  end
end
