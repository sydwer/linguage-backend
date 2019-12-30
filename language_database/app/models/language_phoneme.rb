class LanguagePhoneme < ApplicationRecord
    belongs_to :language
    belongs_to :phoneme
end
