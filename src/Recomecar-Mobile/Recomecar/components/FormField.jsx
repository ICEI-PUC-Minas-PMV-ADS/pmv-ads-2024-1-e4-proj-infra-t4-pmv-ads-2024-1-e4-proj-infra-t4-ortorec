import { View, Text, TextInput, TouchableOpacity, Image } from 'react-native'
import React, { useState } from 'react'

import { icons } from '../constants'

const FormField = ({ title, value, placeholder, handleChangeText, otherStyles, ...props }) => {
  
  const [showPassword, setShowPassword] = useState(false)
  
  
  return (
    <View className={`space-y-2 ${otherStyles}`}>
      <Text className='text-base font-pmedium'>{title}</Text>

      <View className='border-2 w-full h-16 px-4 bg-white rounded-2xl focus:border-secondary items-center
      flex-row'>
        <TextInput
          className='flex-1 font-psemibold text-base mt-2'
          value={value}
          placeholder={placeholder}
          placeholderTextColor="#7b7b8b"
          onChangeText={handleChangeText}
          secureTextEntry={title === 'Senha' && !showPassword}
        />

        {title === 'Senha' && (
          <TouchableOpacity onPress={() => setShowPassword(!showPassword)}>
            <Image source={!showPassword ? icons.eye : icons.eyeHide }
            className='w-10 h-10 '
            resizeMode='contain'
            />
          </TouchableOpacity>
        )}
      </View>
    </View>
  )
}

export default FormField