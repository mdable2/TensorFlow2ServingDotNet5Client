docker run -t --rm -p 8500:8500 -p 8501:8501 -v "%cd%/TrainingModel/ExportedCatsAndDogsModel:/models/cats_and_dogs" -e MODEL_NAME=cats_and_dogs tensorflow/serving &