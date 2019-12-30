class LanguagePhonemesController < ApplicationController
    def index
        language_phonemes = LanguagePhoneme.all 
        render json: language_phonemes
    end

    def show
        language_phoneme = LanguagePhoneme.find(params[:id])
        render json: language_phoneme
    end
end
