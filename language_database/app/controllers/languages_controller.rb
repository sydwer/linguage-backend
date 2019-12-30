class LanguagesController < ApplicationController
    def index
        languages = Language.all 
        render json: languages, include: [:phonemes, :morphology, :language_family, :orthography]
    end

    def show
        language = Language.find(params[:id])
        render json: language, include: [:phonemes, :morphology, :language_family, :orthography]
    end
end
