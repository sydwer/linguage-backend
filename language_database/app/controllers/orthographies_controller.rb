class OrthographiesController < ApplicationController
    def index
        orthographies = Orthography.all
        render json: orthographies
    end

    def show
        orthography = Orthography.find(params[:id])
        render json: orthography
    end
end
