class Language < ApplicationRecord
    belongs_to :language_family
    belongs_to :morphology
    belongs_to :orthography
    has_many :language_phonemes
    has_many :phonemes, through: :language_phonemes
    has_many :comparisons
    has_many :native_languages,foreign_key: :native_language_id, class_name: 'NativeLanguage'
    has_many :target_languages, through: :native_languages
end
